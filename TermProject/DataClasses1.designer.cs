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

namespace TermProject
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="onlineStore")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcustomer(customer instance);
    partial void Updatecustomer(customer instance);
    partial void Deletecustomer(customer instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void Insertproduct(product instance);
    partial void Updateproduct(product instance);
    partial void Deleteproduct(product instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::TermProject.Properties.Settings.Default.onlineStoreConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<customer> customers
		{
			get
			{
				return this.GetTable<customer>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<product> products
		{
			get
			{
				return this.GetTable<product>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.customer")]
	public partial class customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerID;
		
		private string _UserName;
		
		private string _Password;
		
		private decimal _AccountBalance;
		
		private EntitySet<Order> _Orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnAccountBalanceChanging(decimal value);
    partial void OnAccountBalanceChanged();
    #endregion
		
		public customer()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountBalance", DbType="Decimal(18,0) NOT NULL")]
		public decimal AccountBalance
		{
			get
			{
				return this._AccountBalance;
			}
			set
			{
				if ((this._AccountBalance != value))
				{
					this.OnAccountBalanceChanging(value);
					this.SendPropertyChanging();
					this._AccountBalance = value;
					this.SendPropertyChanged("AccountBalance");
					this.OnAccountBalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="customer_Order", Storage="_Orders", ThisKey="CustomerID", OtherKey="CustomerID")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
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
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.customer = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderID;
		
		private int _CustomerID;
		
		private int _ProductID;
		
		private int _ProductAmount;
		
		private System.Nullable<System.DateTime> _OrderDate;
		
		private decimal _TotalOrderAmount;
		
		private EntityRef<customer> _customer;
		
		private EntityRef<product> _product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(int value);
    partial void OnOrderIDChanged();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnProductAmountChanging(int value);
    partial void OnProductAmountChanged();
    partial void OnOrderDateChanging(System.Nullable<System.DateTime> value);
    partial void OnOrderDateChanged();
    partial void OnTotalOrderAmountChanging(decimal value);
    partial void OnTotalOrderAmountChanged();
    #endregion
		
		public Order()
		{
			this._customer = default(EntityRef<customer>);
			this._product = default(EntityRef<product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int NOT NULL")]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					if (this._customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int NOT NULL")]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					if (this._product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductAmount", DbType="Int NOT NULL")]
		public int ProductAmount
		{
			get
			{
				return this._ProductAmount;
			}
			set
			{
				if ((this._ProductAmount != value))
				{
					this.OnProductAmountChanging(value);
					this.SendPropertyChanging();
					this._ProductAmount = value;
					this.SendPropertyChanged("ProductAmount");
					this.OnProductAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="Date")]
		public System.Nullable<System.DateTime> OrderDate
		{
			get
			{
				return this._OrderDate;
			}
			set
			{
				if ((this._OrderDate != value))
				{
					this.OnOrderDateChanging(value);
					this.SendPropertyChanging();
					this._OrderDate = value;
					this.SendPropertyChanged("OrderDate");
					this.OnOrderDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalOrderAmount", DbType="Decimal(18,0) NOT NULL")]
		public decimal TotalOrderAmount
		{
			get
			{
				return this._TotalOrderAmount;
			}
			set
			{
				if ((this._TotalOrderAmount != value))
				{
					this.OnTotalOrderAmountChanging(value);
					this.SendPropertyChanging();
					this._TotalOrderAmount = value;
					this.SendPropertyChanged("TotalOrderAmount");
					this.OnTotalOrderAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="customer_Order", Storage="_customer", ThisKey="CustomerID", OtherKey="CustomerID", IsForeignKey=true)]
		public customer customer
		{
			get
			{
				return this._customer.Entity;
			}
			set
			{
				customer previousValue = this._customer.Entity;
				if (((previousValue != value) 
							|| (this._customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._customer.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._customer.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._CustomerID = value.CustomerID;
					}
					else
					{
						this._CustomerID = default(int);
					}
					this.SendPropertyChanged("customer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_Order", Storage="_product", ThisKey="ProductID", OtherKey="ProductID", IsForeignKey=true)]
		public product product
		{
			get
			{
				return this._product.Entity;
			}
			set
			{
				product previousValue = this._product.Entity;
				if (((previousValue != value) 
							|| (this._product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._product.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._product.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._ProductID = value.ProductID;
					}
					else
					{
						this._ProductID = default(int);
					}
					this.SendPropertyChanged("product");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.product")]
	public partial class product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductID;
		
		private string _ProductName;
		
		private decimal _Price;
		
		private EntitySet<Order> _Orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    #endregion
		
		public product()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(18,0) NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_Order", Storage="_Orders", ThisKey="ProductID", OtherKey="ProductID")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
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
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.product = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.product = null;
		}
	}
}
#pragma warning restore 1591
