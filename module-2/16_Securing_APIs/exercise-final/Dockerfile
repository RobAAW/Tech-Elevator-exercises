# Mount the utilities image which serves as a shared folder
FROM tepublic/te-curriculum-utilities:1.0 AS utilities

# Install LTS version of .NET (3.1.142)
FROM mcr.microsoft.com/dotnet/sdk:3.1

# Set as current directory for RUN, ADD, COPY commands
WORKDIR /app

# Add entire student fork (overwrites previously added files)
ARG SUBMISSION_SUBFOLDER
COPY $SUBMISSION_SUBFOLDER /app

# Overwrite files in student fork with upstream files
COPY AuctionAppServer.Tests /app/AuctionAppServer.Tests
COPY AuctionAppClient.Tests /app/AuctionAppClient.Tests

# Note: Using a custom test script
COPY test.custom.sh ./test.sh

# Copy the common scripts from the utilities image
COPY --from=utilities grade.sh ./
