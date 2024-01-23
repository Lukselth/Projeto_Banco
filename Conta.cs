using System;
using System.Collections.Generic;

namespace TaskT;

public abstract class Conta 
{         
    protected abstract string CPF{get;set;}
	protected abstract double Saldo{get;set;}
	protected abstract string Nome {get;set;}
	protected abstract string TipoDeConta {get; set;}
	protected abstract bool Bloqueado {get;set;}
	protected abstract bool TentarPagar(Dictionary<string,double> item);
}