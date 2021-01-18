using System;
using Xunit;
using CommandAPI.Models;
namespace CommandAPI.Tests
{
    public class CommandTests :IDisposable
    {
        Command testCommand;
        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "Some platform",
                CommandLine = "Some commandline"
            };
        }
        public void Dispose()
        {
         testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            //Arrange
            // var testCommand = new Command
            // {
            //     HowTo = "Do something awesome",
            //     Platform = "xUnit",
            //     CommandLine = "dotnet test"
            // };
            //Act
            testCommand.HowTo = "Execute Unit Tests";
            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatorm()
        {
            //Arrange
            // var testCommand = new Command
            // {
            //     HowTo = "Do something awesome",
            //     Platform = "test platform",
            //     CommandLine = "dotnet test"
            // };
            //Act
            testCommand.Platform = "xUnit";
            //Assert
            Assert.Equal("xUnit", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            //Arrange
            // var testCommand = new Command
            // {
            //     HowTo = "Do something awesome",
            //     Platform = "xUnit",
            //     CommandLine = "commandLine"
            // };
            //Act
            testCommand.CommandLine = "dotnet test";
            //Assert
            Assert.Equal("dotnet test", testCommand.CommandLine);
        }
    }
}