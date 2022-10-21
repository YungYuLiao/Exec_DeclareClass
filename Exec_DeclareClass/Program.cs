using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareClass
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
	}
	//具備 City, ZipCode, Street 等屬性
	class Address
	{
		public string City { get; set; }
		public string ZipCode { get; set; }
		public string Street { get; set; }
	}
	//具備 CountryCode, AreaCode, Number, Ext 等屬性
	class Telephone 
	{
		public string CountryCode { get; set; }
		public string AreaCode { get; set; }
		public string Number { get; set; }
		public string Ext { get; set; }
	}
	//具備 Name, Account, Password, Email, Address, CellPhone,TelePhone 等屬性,
	//其中 Address, TelePhone的型別沿用上面二個類別
	class Member
	{
		public Address address { get; set; }
		public Telephone phone { get; set; }
		public string Name { get; set; }
		public string Account { get; set; }
		public string Passord { get; set; }
		public string Email { get; set; }
		public string Cellphone { get; set; }
		//具備 Register method, 用來註冊新會員, 參數包含 Name, Account, Password, ConfirmPassword, Email
		public void Register(string name, string account, string password, string confirmPassword, string email)
		{

		}
		//具備 ForgetPassword method, 用來處理忘記密碼, 參數包含Name, Email
		public string ForgetPassword (string name, string email)
		{
		}
		//具備 Authenticate method ,用來判斷是否允許使用者登入, 參數包含 Account, Password
		public string Authenticate (string account,string password)
		{

		}
	}
		
	}
