package view;

public class Pessoa {
	
	private static int kp;
	private String nome;
	private char sexo;
	private int idade;
	
	public Pessoa() {
		
	}
	
	public Pessoa(String nome, char sexo, int idade) {
	
	 
	}
	
	public void setKp() {
		this.kp = kp +1;
	}
	
	public static int getKp() {
		return kp;
	}
	
	public void setNome(String nome) {
		this.nome = nome;
	}
	
	public String getNome() {
		return this.nome;
	}
	
	public void setSexo(char sexo) {
		
		if(sexo == 'M' || sexo == 'F') {
			this.sexo = sexo;
		}
		else {
			System.out.print("Sexo Inválido, entre com M ou F");
		}
		
	}
	
	public char getSexo() {
		return this.sexo;
	}
	
	public void setIdade(int idade) {
		this.idade = idade;
	}
	
	public int getIdade() {
		return this.idade;
	}
	
	
}
