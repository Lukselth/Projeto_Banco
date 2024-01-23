using System;
using System.Collections.Generic;

namespace TaskT;

public class Banco : Conta
{
    //atributos da classe abstrata Conta
	protected override string CPF { get; set; }
	protected override double Saldo { get; set; }
	protected override string Nome { get; set; } = "SemNome";
	protected override string TipoDeConta { get; set; }
    protected override bool Bloqueado {get;set;} = false;
	
	//Contrutores 
	
	public Banco()
	{
		this.TipoDeConta = "Poupança";
	}
	
	public Banco(string nome)
	{
		this.Nome = nome;
		this.TipoDeConta = "Poupança";
	}
	
	public Banco(string nome, string cpf)
	{
		this.Nome = nome;
		if (cpf.Length == 11)
		{
			this.CPF = cpf;
			this.Bloqueado = false;
		}
		
		if (cpf.Length != 11)
		{
            this.Bloqueado = true;
			this.Saldo = this.BloquearSaldo();
			this.CPF = $"O Cpf de {this.Nome} está inválido, conta bloqueada!";
			Console.WriteLine($"O Cpf de {this.Nome} não tem 11 números!");
		}
		
		this.TipoDeConta = "Poupança";
	}
	
	//metodos 

	protected double BloquearSaldo()
	{
		return this.Saldo = 0;
	}

	public virtual void Emprestimo(double valor)
	{
	    if(this.Bloqueado)
		{
		    Console.WriteLine($"{this.Nome} Não pode fazer emprestimo pois o saldo está bloqueado!");
		}
		
		else if (valor > 1200)
		{
			Console.WriteLine($"{this.Nome}, não pode fazer emprestimo,\npois o valor está acima de 1200");
		}
		
		else
		{
			this.Saldo += valor;
		}
	}

	public virtual void Depositar(double valor, Banco e)
	{
	    if(this.Bloqueado)
		{
		    if(e.Bloqueado)
			{
			    Console.WriteLine($"{e.Nome} náo pode receber pagamento pois o cpf está invalido");
			}
		    Console.WriteLine($"{this.Nome} Não pode fazer deposito pois o saldo está bloqueado!");
		}
		
		else if (this.Saldo >= valor)
		{
			this.Saldo = this.Saldo - valor;
			e.Saldo += valor;
		}
		
		else 
		{
			Console.WriteLine($"Desculpe {this.Nome}, saldo insuficiente.");
		}
	}

	public double GetSaldo()
	{
	    if(this.Bloqueado)
		{
		    return BloquearSaldo();
		}
		return this.Saldo;
	}

	public virtual string[] Status()
	{
		string[] status =
		{
			"Nome: " + this.Nome,
			"Saldo: " + this.Saldo.ToString("N0"),
			"Cpf: " + this.CPF,
			"Conta: " + this.TipoDeConta,
		};
		return status;
	}
	
	protected override bool TentarPagar(Dictionary<string,double> item)
	{
	    /*if (this.Saldo >= item.Values)
		{
			this.Saldo = this.Saldo - item.Values;
			return true;
		}*/
		 
	    return true;
	}
}
