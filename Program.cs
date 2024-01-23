using System;
using System.Collections.Generic;

namespace TaskT;

class Program
{
	static void Main(string[] args)
	{	
		
		Banco Banco1 = new Banco("Vitor","12345678901");
		UpBanco Banco2 = new UpBanco("Lucas","12345678901");
		
		Banco2.Depositar(50,Banco1);
		Banco1.Depositar(20,Banco2);
		
		Console.WriteLine("saldo UpBanco {0}", Banco2.GetSaldo());
		Console.WriteLine("Saldo Banco {0}",Banco1.GetSaldo());
	}
}