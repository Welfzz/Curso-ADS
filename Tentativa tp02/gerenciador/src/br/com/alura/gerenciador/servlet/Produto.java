package br.com.alura.gerenciador.servlet;

public class Produto {

	private String nome;
	private Integer unidadeCompra;
	private String descricao;
	private Double qtdPrevistoMes;
	private Double precoMaxComprado;
	
	//NOME
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	
	//UNIDADECOMPRA
	public Integer unidadeCompra() {
		return unidadeCompra;
	}
	public void setUnidadeCompra(Integer unidadeCompra) {
		this.unidadeCompra = unidadeCompra;
	}
	
	//DESCRIÇAO
	public String getDescricao() {
		return descricao;
	}
	public void setDescricao(String descricao) {
		this.descricao = descricao;
	}
	
	//qtdPrevistoMes
	public Double getQtdPrevistoMes() {
		return qtdPrevistoMes;
	}
	public void setQtdePrevistoMes(Double qtdPrevistoMes) {
		this.qtdPrevistoMes = qtdPrevistoMes;
	}
	
	//precomaxcomprado
	public Double getPrecoMaxComprado() {
		return precoMaxComprado;
	}
	public void setPrecoMaxComprado(Double precoMaxComprado) {
		this.precoMaxComprado = precoMaxComprado;
	}
		
	
}
