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

namespace DoAn_QuanLyKhachSan
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyKhachSan")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChucVu(ChucVu instance);
    partial void UpdateChucVu(ChucVu instance);
    partial void DeleteChucVu(ChucVu instance);
    partial void InsertPhong(Phong instance);
    partial void UpdatePhong(Phong instance);
    partial void DeletePhong(Phong instance);
    partial void InsertHoaDon(HoaDon instance);
    partial void UpdateHoaDon(HoaDon instance);
    partial void DeleteHoaDon(HoaDon instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertLoaiPhong(LoaiPhong instance);
    partial void UpdateLoaiPhong(LoaiPhong instance);
    partial void DeleteLoaiPhong(LoaiPhong instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::DoAn_QuanLyKhachSan.Properties.Settings.Default.QuanLyKhachSanConnectionString1, mappingSource)
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
		
		public System.Data.Linq.Table<ChucVu> ChucVus
		{
			get
			{
				return this.GetTable<ChucVu>();
			}
		}
		
		public System.Data.Linq.Table<Phong> Phongs
		{
			get
			{
				return this.GetTable<Phong>();
			}
		}
		
		public System.Data.Linq.Table<HoaDon> HoaDons
		{
			get
			{
				return this.GetTable<HoaDon>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<LoaiPhong> LoaiPhongs
		{
			get
			{
				return this.GetTable<LoaiPhong>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChucVu")]
	public partial class ChucVu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maCV;
		
		private string _tenCV;
		
		private EntitySet<NhanVien> _NhanViens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaCVChanging(string value);
    partial void OnmaCVChanged();
    partial void OntenCVChanging(string value);
    partial void OntenCVChanged();
    #endregion
		
		public ChucVu()
		{
			this._NhanViens = new EntitySet<NhanVien>(new Action<NhanVien>(this.attach_NhanViens), new Action<NhanVien>(this.detach_NhanViens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maCV", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maCV
		{
			get
			{
				return this._maCV;
			}
			set
			{
				if ((this._maCV != value))
				{
					this.OnmaCVChanging(value);
					this.SendPropertyChanging();
					this._maCV = value;
					this.SendPropertyChanged("maCV");
					this.OnmaCVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenCV", DbType="NVarChar(100)")]
		public string tenCV
		{
			get
			{
				return this._tenCV;
			}
			set
			{
				if ((this._tenCV != value))
				{
					this.OntenCVChanging(value);
					this.SendPropertyChanging();
					this._tenCV = value;
					this.SendPropertyChanged("tenCV");
					this.OntenCVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChucVu_NhanVien", Storage="_NhanViens", ThisKey="maCV", OtherKey="maCV")]
		public EntitySet<NhanVien> NhanViens
		{
			get
			{
				return this._NhanViens;
			}
			set
			{
				this._NhanViens.Assign(value);
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
		
		private void attach_NhanViens(NhanVien entity)
		{
			this.SendPropertyChanging();
			entity.ChucVu = this;
		}
		
		private void detach_NhanViens(NhanVien entity)
		{
			this.SendPropertyChanging();
			entity.ChucVu = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Phong")]
	public partial class Phong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _soPhong;
		
		private string _tinhTrang;
		
		private string _maLoai;
		
		private EntitySet<HoaDon> _HoaDons;
		
		private EntityRef<LoaiPhong> _LoaiPhong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsoPhongChanging(string value);
    partial void OnsoPhongChanged();
    partial void OntinhTrangChanging(string value);
    partial void OntinhTrangChanged();
    partial void OnmaLoaiChanging(string value);
    partial void OnmaLoaiChanged();
    #endregion
		
		public Phong()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			this._LoaiPhong = default(EntityRef<LoaiPhong>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soPhong", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string soPhong
		{
			get
			{
				return this._soPhong;
			}
			set
			{
				if ((this._soPhong != value))
				{
					this.OnsoPhongChanging(value);
					this.SendPropertyChanging();
					this._soPhong = value;
					this.SendPropertyChanged("soPhong");
					this.OnsoPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tinhTrang", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tinhTrang
		{
			get
			{
				return this._tinhTrang;
			}
			set
			{
				if ((this._tinhTrang != value))
				{
					this.OntinhTrangChanging(value);
					this.SendPropertyChanging();
					this._tinhTrang = value;
					this.SendPropertyChanged("tinhTrang");
					this.OntinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maLoai", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string maLoai
		{
			get
			{
				return this._maLoai;
			}
			set
			{
				if ((this._maLoai != value))
				{
					if (this._LoaiPhong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaLoaiChanging(value);
					this.SendPropertyChanging();
					this._maLoai = value;
					this.SendPropertyChanged("maLoai");
					this.OnmaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_HoaDon", Storage="_HoaDons", ThisKey="soPhong", OtherKey="soPhong")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiPhong_Phong", Storage="_LoaiPhong", ThisKey="maLoai", OtherKey="maLoai", IsForeignKey=true)]
		public LoaiPhong LoaiPhong
		{
			get
			{
				return this._LoaiPhong.Entity;
			}
			set
			{
				LoaiPhong previousValue = this._LoaiPhong.Entity;
				if (((previousValue != value) 
							|| (this._LoaiPhong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiPhong.Entity = null;
						previousValue.Phongs.Remove(this);
					}
					this._LoaiPhong.Entity = value;
					if ((value != null))
					{
						value.Phongs.Add(this);
						this._maLoai = value.maLoai;
					}
					else
					{
						this._maLoai = default(string);
					}
					this.SendPropertyChanged("LoaiPhong");
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
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.Phong = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.Phong = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDon")]
	public partial class HoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maHD;
		
		private string _CMND;
		
		private string _maNV;
		
		private string _soPhong;
		
		private System.Nullable<System.DateTime> _ngayDat;
		
		private System.Nullable<System.DateTime> _ngayTra;
		
		private System.Nullable<decimal> _tienThanhToan;
		
		private EntityRef<Phong> _Phong;
		
		private EntityRef<KhachHang> _KhachHang;
		
		private EntityRef<NhanVien> _NhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaHDChanging(string value);
    partial void OnmaHDChanged();
    partial void OnCMNDChanging(string value);
    partial void OnCMNDChanged();
    partial void OnmaNVChanging(string value);
    partial void OnmaNVChanged();
    partial void OnsoPhongChanging(string value);
    partial void OnsoPhongChanged();
    partial void OnngayDatChanging(System.Nullable<System.DateTime> value);
    partial void OnngayDatChanged();
    partial void OnngayTraChanging(System.Nullable<System.DateTime> value);
    partial void OnngayTraChanged();
    partial void OntienThanhToanChanging(System.Nullable<decimal> value);
    partial void OntienThanhToanChanged();
    #endregion
		
		public HoaDon()
		{
			this._Phong = default(EntityRef<Phong>);
			this._KhachHang = default(EntityRef<KhachHang>);
			this._NhanVien = default(EntityRef<NhanVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maHD", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maHD
		{
			get
			{
				return this._maHD;
			}
			set
			{
				if ((this._maHD != value))
				{
					this.OnmaHDChanging(value);
					this.SendPropertyChanging();
					this._maHD = value;
					this.SendPropertyChanged("maHD");
					this.OnmaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="VarChar(13) NOT NULL", CanBeNull=false)]
		public string CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					if (this._KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maNV", DbType="VarChar(10)")]
		public string maNV
		{
			get
			{
				return this._maNV;
			}
			set
			{
				if ((this._maNV != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaNVChanging(value);
					this.SendPropertyChanging();
					this._maNV = value;
					this.SendPropertyChanged("maNV");
					this.OnmaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soPhong", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string soPhong
		{
			get
			{
				return this._soPhong;
			}
			set
			{
				if ((this._soPhong != value))
				{
					if (this._Phong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsoPhongChanging(value);
					this.SendPropertyChanging();
					this._soPhong = value;
					this.SendPropertyChanged("soPhong");
					this.OnsoPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDat", DbType="Date")]
		public System.Nullable<System.DateTime> ngayDat
		{
			get
			{
				return this._ngayDat;
			}
			set
			{
				if ((this._ngayDat != value))
				{
					this.OnngayDatChanging(value);
					this.SendPropertyChanging();
					this._ngayDat = value;
					this.SendPropertyChanged("ngayDat");
					this.OnngayDatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayTra", DbType="Date")]
		public System.Nullable<System.DateTime> ngayTra
		{
			get
			{
				return this._ngayTra;
			}
			set
			{
				if ((this._ngayTra != value))
				{
					this.OnngayTraChanging(value);
					this.SendPropertyChanging();
					this._ngayTra = value;
					this.SendPropertyChanged("ngayTra");
					this.OnngayTraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tienThanhToan", DbType="Money")]
		public System.Nullable<decimal> tienThanhToan
		{
			get
			{
				return this._tienThanhToan;
			}
			set
			{
				if ((this._tienThanhToan != value))
				{
					this.OntienThanhToanChanging(value);
					this.SendPropertyChanging();
					this._tienThanhToan = value;
					this.SendPropertyChanged("tienThanhToan");
					this.OntienThanhToanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_HoaDon", Storage="_Phong", ThisKey="soPhong", OtherKey="soPhong", IsForeignKey=true)]
		public Phong Phong
		{
			get
			{
				return this._Phong.Entity;
			}
			set
			{
				Phong previousValue = this._Phong.Entity;
				if (((previousValue != value) 
							|| (this._Phong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Phong.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._Phong.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._soPhong = value.soPhong;
					}
					else
					{
						this._soPhong = default(string);
					}
					this.SendPropertyChanged("Phong");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_HoaDon", Storage="_KhachHang", ThisKey="CMND", OtherKey="CMND", IsForeignKey=true)]
		public KhachHang KhachHang
		{
			get
			{
				return this._KhachHang.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._KhachHang.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._CMND = value.CMND;
					}
					else
					{
						this._CMND = default(string);
					}
					this.SendPropertyChanged("KhachHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_HoaDon", Storage="_NhanVien", ThisKey="maNV", OtherKey="maNV", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._maNV = value.maNV;
					}
					else
					{
						this._maNV = default(string);
					}
					this.SendPropertyChanged("NhanVien");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CMND;
		
		private string _tenKH;
		
		private string _diaChi;
		
		private string _gioiTinh;
		
		private string _SDT;
		
		private string _loai;
		
		private EntitySet<HoaDon> _HoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCMNDChanging(string value);
    partial void OnCMNDChanged();
    partial void OntenKHChanging(string value);
    partial void OntenKHChanged();
    partial void OndiaChiChanging(string value);
    partial void OndiaChiChanged();
    partial void OngioiTinhChanging(string value);
    partial void OngioiTinhChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnloaiChanging(string value);
    partial void OnloaiChanged();
    #endregion
		
		public KhachHang()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="VarChar(13) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenKH", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string tenKH
		{
			get
			{
				return this._tenKH;
			}
			set
			{
				if ((this._tenKH != value))
				{
					this.OntenKHChanging(value);
					this.SendPropertyChanging();
					this._tenKH = value;
					this.SendPropertyChanged("tenKH");
					this.OntenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diaChi", DbType="NVarChar(100)")]
		public string diaChi
		{
			get
			{
				return this._diaChi;
			}
			set
			{
				if ((this._diaChi != value))
				{
					this.OndiaChiChanging(value);
					this.SendPropertyChanging();
					this._diaChi = value;
					this.SendPropertyChanged("diaChi");
					this.OndiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gioiTinh", DbType="NVarChar(100)")]
		public string gioiTinh
		{
			get
			{
				return this._gioiTinh;
			}
			set
			{
				if ((this._gioiTinh != value))
				{
					this.OngioiTinhChanging(value);
					this.SendPropertyChanging();
					this._gioiTinh = value;
					this.SendPropertyChanged("gioiTinh");
					this.OngioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="NVarChar(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_loai", DbType="NVarChar(50)")]
		public string loai
		{
			get
			{
				return this._loai;
			}
			set
			{
				if ((this._loai != value))
				{
					this.OnloaiChanging(value);
					this.SendPropertyChanging();
					this._loai = value;
					this.SendPropertyChanged("loai");
					this.OnloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_HoaDon", Storage="_HoaDons", ThisKey="CMND", OtherKey="CMND")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
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
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiPhong")]
	public partial class LoaiPhong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maLoai;
		
		private string _tenLP;
		
		private System.Nullable<decimal> _gia;
		
		private EntitySet<Phong> _Phongs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaLoaiChanging(string value);
    partial void OnmaLoaiChanged();
    partial void OntenLPChanging(string value);
    partial void OntenLPChanged();
    partial void OngiaChanging(System.Nullable<decimal> value);
    partial void OngiaChanged();
    #endregion
		
		public LoaiPhong()
		{
			this._Phongs = new EntitySet<Phong>(new Action<Phong>(this.attach_Phongs), new Action<Phong>(this.detach_Phongs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maLoai", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maLoai
		{
			get
			{
				return this._maLoai;
			}
			set
			{
				if ((this._maLoai != value))
				{
					this.OnmaLoaiChanging(value);
					this.SendPropertyChanging();
					this._maLoai = value;
					this.SendPropertyChanged("maLoai");
					this.OnmaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenLP", DbType="NVarChar(100)")]
		public string tenLP
		{
			get
			{
				return this._tenLP;
			}
			set
			{
				if ((this._tenLP != value))
				{
					this.OntenLPChanging(value);
					this.SendPropertyChanging();
					this._tenLP = value;
					this.SendPropertyChanged("tenLP");
					this.OntenLPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gia", DbType="Money")]
		public System.Nullable<decimal> gia
		{
			get
			{
				return this._gia;
			}
			set
			{
				if ((this._gia != value))
				{
					this.OngiaChanging(value);
					this.SendPropertyChanging();
					this._gia = value;
					this.SendPropertyChanged("gia");
					this.OngiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiPhong_Phong", Storage="_Phongs", ThisKey="maLoai", OtherKey="maLoai")]
		public EntitySet<Phong> Phongs
		{
			get
			{
				return this._Phongs;
			}
			set
			{
				this._Phongs.Assign(value);
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
		
		private void attach_Phongs(Phong entity)
		{
			this.SendPropertyChanging();
			entity.LoaiPhong = this;
		}
		
		private void detach_Phongs(Phong entity)
		{
			this.SendPropertyChanging();
			entity.LoaiPhong = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maNV;
		
		private string _tenNV;
		
		private string _maCV;
		
		private string _gioiTinh;
		
		private System.Nullable<System.DateTime> _ngSinh;
		
		private System.Nullable<System.DateTime> _ngVaoLam;
		
		private string _diaChi;
		
		private string _SDT;
		
		private string _tenDN;
		
		private string _pass;
		
		private EntitySet<HoaDon> _HoaDons;
		
		private EntityRef<ChucVu> _ChucVu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaNVChanging(string value);
    partial void OnmaNVChanged();
    partial void OntenNVChanging(string value);
    partial void OntenNVChanged();
    partial void OnmaCVChanging(string value);
    partial void OnmaCVChanged();
    partial void OngioiTinhChanging(string value);
    partial void OngioiTinhChanged();
    partial void OnngSinhChanging(System.Nullable<System.DateTime> value);
    partial void OnngSinhChanged();
    partial void OnngVaoLamChanging(System.Nullable<System.DateTime> value);
    partial void OnngVaoLamChanged();
    partial void OndiaChiChanging(string value);
    partial void OndiaChiChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OntenDNChanging(string value);
    partial void OntenDNChanged();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    #endregion
		
		public NhanVien()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			this._ChucVu = default(EntityRef<ChucVu>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maNV", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maNV
		{
			get
			{
				return this._maNV;
			}
			set
			{
				if ((this._maNV != value))
				{
					this.OnmaNVChanging(value);
					this.SendPropertyChanging();
					this._maNV = value;
					this.SendPropertyChanged("maNV");
					this.OnmaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenNV", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string tenNV
		{
			get
			{
				return this._tenNV;
			}
			set
			{
				if ((this._tenNV != value))
				{
					this.OntenNVChanging(value);
					this.SendPropertyChanging();
					this._tenNV = value;
					this.SendPropertyChanged("tenNV");
					this.OntenNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maCV", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string maCV
		{
			get
			{
				return this._maCV;
			}
			set
			{
				if ((this._maCV != value))
				{
					if (this._ChucVu.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaCVChanging(value);
					this.SendPropertyChanging();
					this._maCV = value;
					this.SendPropertyChanged("maCV");
					this.OnmaCVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gioiTinh", DbType="NVarChar(20)")]
		public string gioiTinh
		{
			get
			{
				return this._gioiTinh;
			}
			set
			{
				if ((this._gioiTinh != value))
				{
					this.OngioiTinhChanging(value);
					this.SendPropertyChanging();
					this._gioiTinh = value;
					this.SendPropertyChanged("gioiTinh");
					this.OngioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngSinh", DbType="Date")]
		public System.Nullable<System.DateTime> ngSinh
		{
			get
			{
				return this._ngSinh;
			}
			set
			{
				if ((this._ngSinh != value))
				{
					this.OnngSinhChanging(value);
					this.SendPropertyChanging();
					this._ngSinh = value;
					this.SendPropertyChanged("ngSinh");
					this.OnngSinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngVaoLam", DbType="Date")]
		public System.Nullable<System.DateTime> ngVaoLam
		{
			get
			{
				return this._ngVaoLam;
			}
			set
			{
				if ((this._ngVaoLam != value))
				{
					this.OnngVaoLamChanging(value);
					this.SendPropertyChanging();
					this._ngVaoLam = value;
					this.SendPropertyChanged("ngVaoLam");
					this.OnngVaoLamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diaChi", DbType="NVarChar(100)")]
		public string diaChi
		{
			get
			{
				return this._diaChi;
			}
			set
			{
				if ((this._diaChi != value))
				{
					this.OndiaChiChanging(value);
					this.SendPropertyChanging();
					this._diaChi = value;
					this.SendPropertyChanged("diaChi");
					this.OndiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="NVarChar(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenDN", DbType="VarChar(50)")]
		public string tenDN
		{
			get
			{
				return this._tenDN;
			}
			set
			{
				if ((this._tenDN != value))
				{
					this.OntenDNChanging(value);
					this.SendPropertyChanging();
					this._tenDN = value;
					this.SendPropertyChanged("tenDN");
					this.OntenDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="VarChar(50)")]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_HoaDon", Storage="_HoaDons", ThisKey="maNV", OtherKey="maNV")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChucVu_NhanVien", Storage="_ChucVu", ThisKey="maCV", OtherKey="maCV", IsForeignKey=true)]
		public ChucVu ChucVu
		{
			get
			{
				return this._ChucVu.Entity;
			}
			set
			{
				ChucVu previousValue = this._ChucVu.Entity;
				if (((previousValue != value) 
							|| (this._ChucVu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ChucVu.Entity = null;
						previousValue.NhanViens.Remove(this);
					}
					this._ChucVu.Entity = value;
					if ((value != null))
					{
						value.NhanViens.Add(this);
						this._maCV = value.maCV;
					}
					else
					{
						this._maCV = default(string);
					}
					this.SendPropertyChanged("ChucVu");
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
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
	}
}
#pragma warning restore 1591
