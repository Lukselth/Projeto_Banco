using System;

namespace TaskT;

public class UpBanco : Banco
{
    //Construtores 
    public UpBanco() : base()
	{
		this.TipoDeConta = "Corrente";
		this.Saldo = 50.00;
	}	
	public UpBanco(string nome) : base(nome)
	{	
	    this.Nome = nome;
		this.TipoDeConta = "Corrente";
		this.Saldo = 50.00;
	}
	public UpBanco(string nome, string cpf) : base(nome,cpf)
	{
	    this.Nome = nome;
		this.CPF = cpf;
	    this.TipoDeConta = "Corrente";
		this.Saldo = 50.00;
	}
	
	//Metodos
	
	public override void Emprestimo(double valor)
	{	
	    base.Emprestimo(valor);
	}
	
	public override void Depositar(double valor, Banco e)
	{
	    base.Depositar(valor,e);
	}
}
