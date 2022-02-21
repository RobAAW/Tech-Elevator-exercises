# Mount the utilities image which serves as a shared folder
FROM tepublic/te-curriculum-utilities:1.0 AS utilities

# Use TE .NET+MSSQL combined image
FROM tepublic/te-dotnet-mssql:3.1.2019

# Set as current directory for RUN, ADD, COPY commands
WORKDIR /app

# Add entire student fork (overwrites previously added files)
ARG SUBMISSION_SUBFOLDER
COPY $SUBMISSION_SUBFOLDER /app

# If there is a database to be loaded, this environment variable must be set,
# and there must be a script with the name create-$DB_DATABASE-database.sql
ENV DB_DATABASE="UnitedStates"

# Overwrite files in student fork with upstream files
COPY OrderingGroupingExercisesTests /app/OrderingGroupingExercisesTests
COPY create-UnitedStates-database.sql ./

# Copy the common scripts from the utilities image
COPY --from=utilities test.dotnet.3.1.MSSQL.2019.sh ./test.sh
COPY --from=utilities grade.sh ./
