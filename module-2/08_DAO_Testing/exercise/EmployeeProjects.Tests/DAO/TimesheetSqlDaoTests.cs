using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using EmployeeProjects.DAO;
using EmployeeProjects.Models;

namespace EmployeeProjects.Tests.DAO
{
    [TestClass]
    public class TimesheetSqlDaoTests : BaseDaoTests
    {
        private static readonly Timesheet TIMESHEET_1 = new Timesheet(1, 1, 1, DateTime.Parse("2021-01-01"), 1.0M, true, "Timesheet 1");
        private static readonly Timesheet TIMESHEET_2 = new Timesheet(2, 1, 1, DateTime.Parse("2021-01-02"), 1.5M, true, "Timesheet 2");
        private static readonly Timesheet TIMESHEET_3 = new Timesheet(3, 2, 1, DateTime.Parse("2021-01-01"), 0.25M, true, "Timesheet 3");
        private static readonly Timesheet TIMESHEET_4 = new Timesheet(4, 2, 2, DateTime.Parse("2021-02-01"), 2.0M, false, "Timesheet 4");

        private Timesheet testTimesheet;

        private TimesheetSqlDao dao;

    
        [TestInitialize]
        public override void Setup()
        {
            testTimesheet = new Timesheet(5,2,2, DateTime.Parse("2021-03-01"), 3.5M, true, "Timesheet 5");
            dao = new TimesheetSqlDao(ConnectionString);
            base.Setup();
        }

        [TestMethod]
        public void GetTimesheet_ReturnsCorrectTimesheetForId()
        {
            Timesheet timesheet = dao.GetTimesheet(1);
            AssertTimesheetsMatch(TIMESHEET_1, timesheet);

            timesheet = dao.GetTimesheet(2);
            AssertTimesheetsMatch(TIMESHEET_2, timesheet);
        }

        [TestMethod]
        public void GetTimesheet_ReturnsNullWhenIdNotFound()
        {
            Timesheet timesheet = dao.GetTimesheet(99);
            Assert.IsNull(timesheet);
        }

        [TestMethod]
        public void GetTimesheetsByEmployeeId_ReturnsListOfAllTimesheetsForEmployee()
        {
            IList<Timesheet> timesheets = dao.GetTimesheetsByEmployeeId(1);
            Assert.AreEqual(2, timesheets.Count);
            AssertTimesheetsMatch(TIMESHEET_1, timesheets[0]);
            AssertTimesheetsMatch(TIMESHEET_2, timesheets[1]);

            timesheets = dao.GetTimesheetsByEmployeeId(2);
            Assert.AreEqual(2, timesheets.Count);
            AssertTimesheetsMatch(TIMESHEET_3, timesheets[0]);
            AssertTimesheetsMatch(TIMESHEET_4, timesheets[1]);
        }

        [TestMethod]
        public void GetTimesheetsByProjectId_ReturnsListOfAllTimesheetsForProject()
        {
            IList<Timesheet> timesheets = dao.GetTimesheetsByProjectId(1);
            Assert.AreEqual(3, timesheets.Count);
            AssertTimesheetsMatch(TIMESHEET_1, timesheets[0]);
            AssertTimesheetsMatch(TIMESHEET_2, timesheets[1]);
            AssertTimesheetsMatch(TIMESHEET_3, timesheets[2]);

            timesheets = dao.GetTimesheetsByProjectId(2);
            Assert.AreEqual(1, timesheets.Count);
            AssertTimesheetsMatch(TIMESHEET_4, timesheets[0]);

        }

        [TestMethod]
        public void CreateTimesheet_ReturnsTimesheetWithIdAndExpectedValues()
        {
            Timesheet createdTimesheet = dao.CreateTimesheet(testTimesheet);

            int newId = createdTimesheet.TimesheetId;
            Assert.IsTrue(newId > 0);

            testTimesheet.TimesheetId = newId;
            AssertTimesheetsMatch(testTimesheet, createdTimesheet);
        }

        [TestMethod]
        public void CreatedTimesheetHasExpectedValuesWhenRetrieved()
        {
            Timesheet createdTimesheet = dao.CreateTimesheet(testTimesheet);

            int newId = createdTimesheet.TimesheetId;
            Timesheet retrievedTimesheet = dao.GetTimesheet(newId);

            AssertTimesheetsMatch(createdTimesheet, retrievedTimesheet);
        }

        [TestMethod]
        public void UpdatedTimesheetHasExpectedValuesWhenRetrieved()
        {
            Timesheet tsToUpdate = dao.GetTimesheet(1);

            tsToUpdate.Description = "TS1";

            dao.UpdateTimesheet(tsToUpdate);

            Timesheet retrievedTS = dao.GetTimesheet(1);
            AssertTimesheetsMatch(tsToUpdate, retrievedTS);
        }

        [TestMethod]
        public void DeletedTimesheetCantBeRetrieved()
        {
            dao.DeleteTimesheet(4);

            Timesheet retrievedTs = dao.GetTimesheet(4);
            Assert.IsNull(retrievedTs);

            IList<Timesheet> timesheets = dao.GetTimesheetsByEmployeeId(2);
            Assert.AreEqual(1, timesheets.Count);
            AssertTimesheetsMatch(TIMESHEET_3, timesheets[0]);
        }

        [TestMethod]
        public void GetBillableHours_ReturnsCorrectTotal()
        {
            decimal billableHours = 2.5M;
            decimal actual = dao.GetBillableHours(1, 1);

            Assert.AreEqual(billableHours, actual);
        }

        private void AssertTimesheetsMatch(Timesheet expected, Timesheet actual)
        {
            Assert.AreEqual(expected.TimesheetId, actual.TimesheetId);
            Assert.AreEqual(expected.EmployeeId, actual.EmployeeId);
            Assert.AreEqual(expected.ProjectId, actual.ProjectId);
            Assert.AreEqual(expected.DateWorked, actual.DateWorked);
            Assert.AreEqual(expected.HoursWorked, actual.HoursWorked);
            Assert.AreEqual(expected.IsBillable, actual.IsBillable);
            Assert.AreEqual(expected.Description, actual.Description);
        }
    }
}
