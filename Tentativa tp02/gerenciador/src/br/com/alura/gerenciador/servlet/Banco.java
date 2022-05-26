package br.com.alura.gerenciador.servlet;

import java.util.ArrayList;
import java.util.List;

import javax.swing.text.html.HTMLDocument.Iterator;

public class Banco {
	
	private static List<Produto> lista = new ArrayList<>();
	
	static {
		Produto produto = new Produto();
		produto.setNome("Alura");
		Produto produto2 = new Produto();
		produto2.setNome("Caelum");
		lista.add(produto);
		lista.add(produto2);
	}

	public void adiciona(Produto produto) {
		Banco.lista.add(produto);
	}
	
	public List<Produto> getProdutos(){
		return Banco.lista;
	}
	
	public void removeEmpresa(Integer id) {
		Iterator<Produto> it = lista.iterator();
		
		while(it.hasNext())...
	}

}
