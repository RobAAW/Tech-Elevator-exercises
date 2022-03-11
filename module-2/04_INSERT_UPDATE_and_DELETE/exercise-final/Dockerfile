# Mount the utilities image which serves as a shared folder
FROM tepublic/te-curriculum-utilities:1.0 AS utilities

# Use TE .NET+MSSQL combined image
FROM tepublic/te-dotnet-mssql:3.1.2019

# Set as current directory for RUN, ADD, COPY commands
WORKDIR /app

# Add entire student fork (overwrites previously added files)
ARG SUBMISSION_SUBFOLDER
COPY $SUBMISSION_SUBFOLDER /app

# If there is a database to be loaded before the exercises, an "ENV DB_DATABASE" command goes here (see other days in this unit).
# By eliminating this env variable, test.sh will *not* try to run a create command. Also, the test code will fall back to the 
# default database name (which is MovieDBTemp) when it creaets, loads and drops the database.

# Overwrite files in student fork with upstream files
COPY InsertUpdateDeleteExercise.Tests /app/InsertUpdateDeleteExercise.Tests

# Copy the common scripts from the utilities image
COPY --from=utilities test.dotnet.3.1.MSSQL.2019.sh ./test.sh
COPY --from=utilities grade.sh ./
