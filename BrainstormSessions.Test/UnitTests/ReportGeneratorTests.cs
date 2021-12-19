namespace BrainstormSessions.Test.UnitTests
{
    using System.IO;
    using Xunit;

    public  class ReportGeneratorTests
    {
        private ReportGenerator _reportGenerator;
        private readonly string _readPath = "C:\\Users\\Maxim_Mochalkin\\source\\repos\\For course\\Logging\\Logging\\BrainstormSessions\\wwwroot\\Logs\\Log.txt";
        private readonly string _writePath = "C:\\Users\\Maxim_Mochalkin\\source\\repos\\For course\\Logging\\Logging\\BrainstormSessions\\wwwroot\\Logs\\Report.txt";

        [Fact]
        public void ReportGenerator_GenerateLogReport_ShouldBeSuccess()
        {
            // Arrange
            _reportGenerator = new ReportGenerator();

            // Act
            _reportGenerator.GenerateLogReport(_readPath, _writePath);

            // Assert
            Assert.True(File.Exists(_writePath));
        }
    }
}
