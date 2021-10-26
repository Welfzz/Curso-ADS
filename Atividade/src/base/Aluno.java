package base;

import java.util.ArrayList;
import java.util.List;
import java.util.UUID;

public class Aluno {
	
	
	private String nome;
	private int idade;
	private String endereco;
	private UUID uuid;
	
	//getters
	
	public Aluno(String n, int ida, String end) {
		
	}

	public String getEndereco() {
		return this.endereco;
	}
	
	public int getIdade() {
		return this.idade;
	}
	
	public String getNome() {
		return this.nome;
	}
	
	public UUID getUuid() {
		return this.uuid;
	}
	
	//setters
	
	public void setEndereco(String endereco) {
		this.endereco = endereco;
		
	}
	public void setNome(String nome) {
		this.nome = nome;
		
	}
	public void setIdade(int idade) {
		this.idade = idade;
		
	}
	public void setUuid(UUID uuid) {
		this.uuid = uuid;
		
	}

	
	

}
