﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AHMAD_MAHAMEED_DATA
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EMPLOYEEDATABASE")]
	public partial class MYDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployeeCard(EmployeeCard instance);
    partial void UpdateEmployeeCard(EmployeeCard instance);
    partial void DeleteEmployeeCard(EmployeeCard instance);
    partial void InsertPersonalCard(PersonalCard instance);
    partial void UpdatePersonalCard(PersonalCard instance);
    partial void DeletePersonalCard(PersonalCard instance);
    #endregion
		
		public MYDBDataContext() : 
				base(global::AHMAD_MAHAMEED_DATA.Properties.Settings.Default.EMPLOYEEDATABASEConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public MYDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MYDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MYDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MYDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EmployeeCard> EmployeeCards
		{
			get
			{
				return this.GetTable<EmployeeCard>();
			}
		}
		
		public System.Data.Linq.Table<PersonalCard> PersonalCards
		{
			get
			{
				return this.GetTable<PersonalCard>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmployeeCard")]
	public partial class EmployeeCard : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _JobTitle;
		
		private System.Nullable<double> _Salary;
		
		private System.Nullable<int> _ssn;
		
		private EntityRef<PersonalCard> _PersonalCard;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnJobTitleChanging(string value);
    partial void OnJobTitleChanged();
    partial void OnSalaryChanging(System.Nullable<double> value);
    partial void OnSalaryChanged();
    partial void OnssnChanging(System.Nullable<int> value);
    partial void OnssnChanged();
    #endregion
		
		public EmployeeCard()
		{
			this._PersonalCard = default(EntityRef<PersonalCard>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobTitle", DbType="NVarChar(MAX)")]
		public string JobTitle
		{
			get
			{
				return this._JobTitle;
			}
			set
			{
				if ((this._JobTitle != value))
				{
					this.OnJobTitleChanging(value);
					this.SendPropertyChanging();
					this._JobTitle = value;
					this.SendPropertyChanged("JobTitle");
					this.OnJobTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Float")]
		public System.Nullable<double> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ssn", DbType="Int")]
		public System.Nullable<int> ssn
		{
			get
			{
				return this._ssn;
			}
			set
			{
				if ((this._ssn != value))
				{
					if (this._PersonalCard.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnssnChanging(value);
					this.SendPropertyChanging();
					this._ssn = value;
					this.SendPropertyChanged("ssn");
					this.OnssnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PersonalCard_EmployeeCard", Storage="_PersonalCard", ThisKey="ssn", OtherKey="SSN", IsForeignKey=true)]
		public PersonalCard PersonalCard
		{
			get
			{
				return this._PersonalCard.Entity;
			}
			set
			{
				PersonalCard previousValue = this._PersonalCard.Entity;
				if (((previousValue != value) 
							|| (this._PersonalCard.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PersonalCard.Entity = null;
						previousValue.EmployeeCards.Remove(this);
					}
					this._PersonalCard.Entity = value;
					if ((value != null))
					{
						value.EmployeeCards.Add(this);
						this._ssn = value.SSN;
					}
					else
					{
						this._ssn = default(Nullable<int>);
					}
					this.SendPropertyChanged("PersonalCard");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PersonalCard")]
	public partial class PersonalCard : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SSN;
		
		private string _Gender;
		
		private System.Nullable<System.DateTime> _Bdate;
		
		private string _BPlace;
		
		private string _MotherName;
		
		private string _FullName;
		
		private EntitySet<EmployeeCard> _EmployeeCards;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSSNChanging(int value);
    partial void OnSSNChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnBdateChanging(System.Nullable<System.DateTime> value);
    partial void OnBdateChanged();
    partial void OnBPlaceChanging(string value);
    partial void OnBPlaceChanged();
    partial void OnMotherNameChanging(string value);
    partial void OnMotherNameChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    #endregion
		
		public PersonalCard()
		{
			this._EmployeeCards = new EntitySet<EmployeeCard>(new Action<EmployeeCard>(this.attach_EmployeeCards), new Action<EmployeeCard>(this.detach_EmployeeCards));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SSN", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SSN
		{
			get
			{
				return this._SSN;
			}
			set
			{
				if ((this._SSN != value))
				{
					this.OnSSNChanging(value);
					this.SendPropertyChanging();
					this._SSN = value;
					this.SendPropertyChanged("SSN");
					this.OnSSNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Char(10)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bdate", DbType="DateTime")]
		public System.Nullable<System.DateTime> Bdate
		{
			get
			{
				return this._Bdate;
			}
			set
			{
				if ((this._Bdate != value))
				{
					this.OnBdateChanging(value);
					this.SendPropertyChanging();
					this._Bdate = value;
					this.SendPropertyChanged("Bdate");
					this.OnBdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BPlace", DbType="NVarChar(MAX)")]
		public string BPlace
		{
			get
			{
				return this._BPlace;
			}
			set
			{
				if ((this._BPlace != value))
				{
					this.OnBPlaceChanging(value);
					this.SendPropertyChanging();
					this._BPlace = value;
					this.SendPropertyChanged("BPlace");
					this.OnBPlaceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MotherName", DbType="NVarChar(MAX)")]
		public string MotherName
		{
			get
			{
				return this._MotherName;
			}
			set
			{
				if ((this._MotherName != value))
				{
					this.OnMotherNameChanging(value);
					this.SendPropertyChanging();
					this._MotherName = value;
					this.SendPropertyChanged("MotherName");
					this.OnMotherNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="NVarChar(MAX)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this.OnFullNameChanging(value);
					this.SendPropertyChanging();
					this._FullName = value;
					this.SendPropertyChanged("FullName");
					this.OnFullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PersonalCard_EmployeeCard", Storage="_EmployeeCards", ThisKey="SSN", OtherKey="ssn")]
		public EntitySet<EmployeeCard> EmployeeCards
		{
			get
			{
				return this._EmployeeCards;
			}
			set
			{
				this._EmployeeCards.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_EmployeeCards(EmployeeCard entity)
		{
			this.SendPropertyChanging();
			entity.PersonalCard = this;
		}
		
		private void detach_EmployeeCards(EmployeeCard entity)
		{
			this.SendPropertyChanging();
			entity.PersonalCard = null;
		}
	}
}
#pragma warning restore 1591
