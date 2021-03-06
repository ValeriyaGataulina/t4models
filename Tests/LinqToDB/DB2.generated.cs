﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/t4models).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace DB2DataContext
{
	/// <summary>
	/// Database       : TESTDATA
	/// Data Source    : DBHost:50000
	/// Server Version : 10.01.0000
	/// </summary>
	public partial class TESTDATADB : LinqToDB.Data.DataConnection
	{
		public ITable<ALLTYPE>      ALLTYPES       { get { return this.GetTable<ALLTYPE>(); } }
		public ITable<Child>        Children       { get { return this.GetTable<Child>(); } }
		public ITable<Doctor>       Doctors        { get { return this.GetTable<Doctor>(); } }
		public ITable<GrandChild>   GrandChildren  { get { return this.GetTable<GrandChild>(); } }
		public ITable<LinqDataType> LinqDataTypes  { get { return this.GetTable<LinqDataType>(); } }
		public ITable<MASTERTABLE>  MASTERTABLEs   { get { return this.GetTable<MASTERTABLE>(); } }
		public ITable<Parent>       Parents        { get { return this.GetTable<Parent>(); } }
		public ITable<Patient>      Patients       { get { return this.GetTable<Patient>(); } }
		public ITable<Person>       People         { get { return this.GetTable<Person>(); } }
		public ITable<PERSONVIEW>   PERSONVIEWs    { get { return this.GetTable<PERSONVIEW>(); } }
		public ITable<SLAVETABLE>   SLAVETABLEs    { get { return this.GetTable<SLAVETABLE>(); } }
		public ITable<TestIdentity> TestIdentities { get { return this.GetTable<TestIdentity>(); } }
		public ITable<TestTable>    TestTables     { get { return this.GetTable<TestTable>(); } }
		public ITable<TestTable2>   TestTable2     { get { return this.GetTable<TestTable2>(); } }
		public ITable<TestTable3>   TestTable3     { get { return this.GetTable<TestTable3>(); } }

		public TESTDATADB()
		{
		}

		public TESTDATADB(string configuration)
			: base(configuration)
		{
		}
	}

	[Table(Schema="ADMINISTRATOR", Name="ALLTYPES")]
	public partial class ALLTYPE
	{
		[PrimaryKey, Identity] public int       ID                { get; set; } // INTEGER
		[Column,     Nullable] public long?     BIGINTDATATYPE    { get; set; } // BIGINT
		[Column,     Nullable] public int?      INTDATATYPE       { get; set; } // INTEGER
		[Column,     Nullable] public short?    SMALLINTDATATYPE  { get; set; } // SMALLINT
		[Column,     Nullable] public decimal?  DECIMALDATATYPE   { get; set; } // DECIMAL
		[Column,     Nullable] public decimal?  DECFLOATDATATYPE  { get; set; } // DECFLOAT
		[Column,     Nullable] public float?    REALDATATYPE      { get; set; } // REAL
		[Column,     Nullable] public double?   DOUBLEDATATYPE    { get; set; } // DOUBLE
		[Column,     Nullable] public char?     CHARDATATYPE      { get; set; } // CHARACTER(1)
		[Column,     Nullable] public string    VARCHARDATATYPE   { get; set; } // VARCHAR(20)
		[Column,     Nullable] public string    CLOBDATATYPE      { get; set; } // CLOB(1048576)
		[Column,     Nullable] public string    DBCLOBDATATYPE    { get; set; } // DBCLOB(100)
		[Column,     Nullable] public string    BINARYDATATYPE    { get; set; } // CHARACTER(5)
		[Column,     Nullable] public string    VARBINARYDATATYPE { get; set; } // VARCHAR(5)
		[Column,     Nullable] public byte[]    BLOBDATATYPE      { get; set; } // BLOB(1048576)
		[Column,     Nullable] public string    GRAPHICDATATYPE   { get; set; } // GRAPHIC(10)
		[Column,     Nullable] public DateTime? DATEDATATYPE      { get; set; } // DATE
		[Column,     Nullable] public TimeSpan? TIMEDATATYPE      { get; set; } // TIME
		[Column,     Nullable] public DateTime? TIMESTAMPDATATYPE { get; set; } // TIMESTAMP
		[Column,     Nullable] public string    XMLDATATYPE       { get; set; } // XML
	}

	[Table(Schema="ADMINISTRATOR", Name="Child")]
	public partial class Child
	{
		[Column, Nullable] public int? ParentID { get; set; } // INTEGER
		[Column, Nullable] public int? ChildID  { get; set; } // INTEGER
	}

	[Table(Schema="ADMINISTRATOR", Name="Doctor")]
	public partial class Doctor
	{
		[Column, NotNull] public int    PersonID { get; set; } // INTEGER
		[Column, NotNull] public string Taxonomy { get; set; } // VARCHAR(50)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public Person Person { get; set; }

		#endregion
	}

	[Table(Schema="ADMINISTRATOR", Name="GrandChild")]
	public partial class GrandChild
	{
		[Column, Nullable] public int? ParentID     { get; set; } // INTEGER
		[Column, Nullable] public int? ChildID      { get; set; } // INTEGER
		[Column, Nullable] public int? GrandChildID { get; set; } // INTEGER
	}

	[Table(Schema="ADMINISTRATOR", Name="LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column, Nullable] public int?      ID             { get; set; } // INTEGER
		[Column, Nullable] public decimal?  MoneyValue     { get; set; } // DECIMAL
		[Column, Nullable] public DateTime? DateTimeValue  { get; set; } // TIMESTAMP
		[Column, Nullable] public DateTime? DateTimeValue2 { get; set; } // TIMESTAMP
		[Column, Nullable] public short?    BoolValue      { get; set; } // SMALLINT
		[Column, Nullable] public string    GuidValue      { get; set; } // CHARACTER(16)
		[Column, Nullable] public byte[]    BinaryValue    { get; set; } // BLOB(5000)
		[Column, Nullable] public short?    SmallIntValue  { get; set; } // SMALLINT
		[Column, Nullable] public int?      IntValue       { get; set; } // INTEGER
		[Column, Nullable] public long?     BigIntValue    { get; set; } // BIGINT
	}

	[Table(Schema="ADMINISTRATOR", Name="MASTERTABLE")]
	public partial class MASTERTABLE
	{
		[PrimaryKey(0), NotNull] public int ID1 { get; set; } // INTEGER
		[PrimaryKey(1), NotNull] public int ID2 { get; set; } // INTEGER

		#region Associations

		/// <summary>
		/// FK_SLAVETABLE_MASTERTABLE_BackReference
		/// </summary>
		[Association(ThisKey="ID1, ID2", OtherKey="ID222222222222222222222222, ID1", CanBeNull=false)]
		public IEnumerable<SLAVETABLE> SLAVETABLEs { get; set; }

		#endregion
	}

	[Table(Schema="ADMINISTRATOR", Name="Parent")]
	public partial class Parent
	{
		[Column, Nullable] public int? ParentID { get; set; } // INTEGER
		[Column, Nullable] public int? Value1   { get; set; } // INTEGER
	}

	[Table(Schema="ADMINISTRATOR", Name="Patient")]
	public partial class Patient
	{
		[Column, NotNull] public int    PersonID  { get; set; } // INTEGER
		[Column, NotNull] public string Diagnosis { get; set; } // VARCHAR(256)
	}

	[Table(Schema="ADMINISTRATOR", Name="Person")]
	public partial class Person
	{
		[PrimaryKey, Identity   ] public int    PersonID   { get; set; } // INTEGER
		[Column,     NotNull    ] public string FirstName  { get; set; } // VARCHAR(50)
		[Column,     NotNull    ] public string LastName   { get; set; } // VARCHAR(50)
		[Column,        Nullable] public string MiddleName { get; set; } // VARCHAR(50)
		[Column,     NotNull    ] public char   Gender     { get; set; } // CHARACTER(1)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person_BackReference
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public IEnumerable<Doctor> Doctors { get; set; }

		#endregion
	}

	// View
	[Table(Schema="ADMINISTRATOR", Name="PERSONVIEW")]
	public partial class PERSONVIEW
	{
		[Column, NotNull    ] public int    PersonID   { get; set; } // INTEGER
		[Column, NotNull    ] public string FirstName  { get; set; } // VARCHAR(50)
		[Column, NotNull    ] public string LastName   { get; set; } // VARCHAR(50)
		[Column,    Nullable] public string MiddleName { get; set; } // VARCHAR(50)
		[Column, NotNull    ] public char   Gender     { get; set; } // CHARACTER(1)
	}

	[Table(Schema="ADMINISTRATOR", Name="SLAVETABLE")]
	public partial class SLAVETABLE
	{
		[Column,                                  NotNull] public int ID1                        { get; set; } // INTEGER
		[Column("ID 2222222222222222222222  22"), NotNull] public int ID222222222222222222222222 { get; set; } // INTEGER
		[Column("ID 2222222222222222"),           NotNull] public int ID2222222222222222         { get; set; } // INTEGER

		#region Associations

		/// <summary>
		/// FK_SLAVETABLE_MASTERTABLE
		/// </summary>
		[Association(ThisKey="ID222222222222222222222222, ID1", OtherKey="ID1, ID2", CanBeNull=false)]
		public MASTERTABLE MASTERTABLE { get; set; }

		#endregion
	}

	[Table(Schema="ADMINISTRATOR", Name="TestIdentity")]
	public partial class TestIdentity
	{
		[PrimaryKey, Identity] public int ID { get; set; } // INTEGER
	}

	[Table(Schema="ADMINISTRATOR", Name="TestTable")]
	public partial class TestTable
	{
		[PrimaryKey, Identity   ] public int       ID          { get; set; } // INTEGER
		[Column,     NotNull    ] public string    Name        { get; set; } // VARGRAPHIC(50)
		[Column,        Nullable] public string    Description { get; set; } // VARGRAPHIC(250)
		[Column,        Nullable] public DateTime? CreatedOn   { get; set; } // TIMESTAMP
	}

	[Table(Schema="ADMINISTRATOR", Name="TestTable2")]
	public partial class TestTable2
	{
		[PrimaryKey, Identity   ] public int       ID          { get; set; } // INTEGER
		[Column,     NotNull    ] public string    Name        { get; set; } // VARGRAPHIC(50)
		[Column,        Nullable] public string    Description { get; set; } // VARGRAPHIC(250)
		[Column,        Nullable] public DateTime? CreatedOn   { get; set; } // TIMESTAMP
	}

	[Table(Schema="ADMINISTRATOR", Name="TestTable3")]
	public partial class TestTable3
	{
		[PrimaryKey, NotNull] public int    ID   { get; set; } // INTEGER
		[Column,     NotNull] public string Name { get; set; } // VARGRAPHIC(50)
	}

	public static partial class TESTDATADBStoredProcedures
	{
		#region PERSON_SELECTBYKEY

		public static IEnumerable<Person> PERSON_SELECTBYKEY(this DataConnection dataConnection, int? ID)
		{
			return dataConnection.QueryProc<Person>("ADMINISTRATOR.PERSON_SELECTBYKEY",
				new DataParameter("ID", ID));
		}

		#endregion
	}

	public static partial class TableExtensions
	{
		public static ALLTYPE Find(this ITable<ALLTYPE> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static MASTERTABLE Find(this ITable<MASTERTABLE> table, int ID1, int ID2)
		{
			return table.FirstOrDefault(t =>
				t.ID1 == ID1 &&
				t.ID2 == ID2);
		}

		public static Person Find(this ITable<Person> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static TestIdentity Find(this ITable<TestIdentity> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TestTable Find(this ITable<TestTable> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TestTable2 Find(this ITable<TestTable2> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TestTable3 Find(this ITable<TestTable3> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}
	}
}
