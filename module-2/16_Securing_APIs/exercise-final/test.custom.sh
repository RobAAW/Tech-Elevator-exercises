#!/bin/bash
echo test.custom.sh

# Run the tests, sending output to a file
dotnet test AuctionAppClient.Tests > output_client.txt
dotnet test AuctionAppServer.Tests > output_server.txt

# Search the results file for total number of tests.
# changed the lookbehind (see the Java exercises) to "reset match" (\K) because the lookbehind expression needs to be variable length, which is not allowed.
number_of_tests_client=$(grep -P -o "Total tests: *\K\d+" output_client.txt|head -1)
number_of_tests_server=$(grep -P -o "Total tests: *\K\d+" output_server.txt|head -1)

# set variables to zero if they weren't assigned because no tests were run
if [ -z "$number_of_tests_client" ]
then
    number_of_tests_client=0
fi
if [ -z "$number_of_tests_server" ]
then
    number_of_tests_server=0
fi
number_of_tests=$(($number_of_tests_client + $number_of_tests_server))

# The tests didn't run and something else is wrong
if [ -z "$number_of_tests" ]
then
    # Java tests used 'sed' to print a portion of the file. Here we are printing the entire output file
    sh grade.sh error 'There was an error that prevented the tests from executing.'
    cat output_client.txt
    cat output_server.txt
    exit 1  ### Error
fi

# changed the lookbehind to "reset match" (\K) because the lookbehind expression needs to be variable length, which is not allowed.
number_failed_client=$(grep -P -o "Failed: *\K\d+" output_client.txt|head -1)
number_passed_client=$(grep -P -o "Passed: *\K\d+" output_client.txt|head -1)
number_failed_server=$(grep -P -o "Failed: *\K\d+" output_server.txt|head -1)
number_passed_server=$(grep -P -o "Passed: *\K\d+" output_server.txt|head -1)

# set variables to zero if they weren't assigned because there's no failed/passed tests
if [ -z "$number_failed_client" ]
then
    number_failed_client=0 # "Failed" line doesn't appear if there's no failed tests, so must set to 0 for (number_failed_client + number_failed_server)
fi
if [ -z "$number_failed_server" ]
then
    number_failed_server=0 # "Failed" line doesn't appear if there's no failed tests, so must set to 0 for (number_failed_client + number_failed_server)
fi

if [ -z "$number_passed_client" ]
then
    number_passed_client=0 # "Passed" line doesn't appear if there's no passed tests, so must set to 0 for (number_passed_client + number_passed_server) and (number_passed of number_of_tests)
fi
if [ -z "$number_passed_server" ]
then
    number_passed_server=0 # "Passed" line doesn't appear if there's no passed tests, so must set to 0 for (number_passed_client + number_passed_server) and (number_passed of number_of_tests)
fi

number_failed=$(($number_failed_client + $number_failed_server))
number_passed=$(($number_passed_client + $number_passed_server))

# Call the script which writes a grading file and reports the result to the user.
sh grade.sh $number_passed $number_of_tests

# Print the portion of the output file that follows the search phrase
echo ---------------------------------------------------------------------------------------
echo Client output:
echo ---------------------------------------------------------------------------------------
sed -n '/Starting test execution, please wait.../,$p' output_client.txt
echo ---------------------------------------------------------------------------------------
echo Server output:
echo ---------------------------------------------------------------------------------------
sed -n '/Starting test execution, please wait.../,$p' output_server.txt
