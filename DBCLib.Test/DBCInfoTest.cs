﻿using Xunit;

namespace DBCLib.Test
{
    public class DBCInfoTest
    {
        [Fact]
        public void DBCRecords_AreEqual()
        {
            DBCInfo dbcInfo = new DBCInfo(0, 1, 2, 3);

            Assert.Equal((uint)0, dbcInfo.DBCRecords);
        }

        [Fact]
        public void DBCFields_AreEqual()
        {
            DBCInfo dbcInfo = new DBCInfo(0, 1, 2, 3);

            Assert.Equal((uint)1, dbcInfo.DBCFields);
        }

        [Fact]
        public void RecordSize_AreEqual()
        {
            DBCInfo dbcInfo = new DBCInfo(0, 1, 2, 3);

            Assert.Equal((uint)2, dbcInfo.RecordSize);
        }

        [Fact]
        public void StringSize_AreEqual()
        {
            DBCInfo dbcInfo = new DBCInfo(0, 1, 2, 3);

            Assert.Equal((uint)3, dbcInfo.StringSize);
        }
    }
}
