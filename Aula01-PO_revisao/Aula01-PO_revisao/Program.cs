using Aula01_PO_revisao;
using Aula01_PO_revisao.components;
using System;
using System.Numerics;
using System.IO;
using System.Diagnostics;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Universo universo = new Universo("Iagoneta", "Bluadep", 6093, new DateTime(2009, 10, 5));

string mensagem = $"{universo.Planeta}\n{universo.Lua}\n{universo.MassaPlaneta}\n{universo.DataDescoberta}";

Console.WriteLine(mensagem);

universo.anotacoes(mensagem);