package base;

import javax.swing.JLabel;

public class Teste extends Thread {
	
	private int maximo;
	private int prioridade_1;
	private int prioridade_2;
	/*public Teste(int maximo, int prioridade_1, int prioridade_2) {
		this.maximo = maximo;
		this.prioridade_1 = prioridade_1;
		this.prioridade_2 = prioridade_2;
	}*/
	
	public int getMaximo() {
		return this.maximo;
	}
	public int getPriori1() {
		return this.prioridade_1;
	}
	public int getPriori2() {
		return this.prioridade_2;
	}
	
	
	public void setMaximo(int max) {
		this.maximo = max;
	}
	public void setPriori1(int prio1) {
		this.prioridade_1 = prio1;
	}
	public void setPriori2(int prio2) {
		this.prioridade_2 = prio2;
	}
	
	
	public void run() {

		
		for(int i = this.prioridade_1; i<= this.prioridade_2; i++) {
			
			System.out.print(i + " ");
			
			
		}
		System.out.println();
		
		for(int i = this.maximo; i >= this.prioridade_1; i--) {
			
			System.out.print(i + " ");
			
		}
		
		
		
	}
	
	

}
