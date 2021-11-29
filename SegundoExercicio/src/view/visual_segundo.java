package view;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class visual_segundo extends JFrame {

	private JPanel contentPane;
	private JTextField texto_numero;
	private JTextField texto_nome;
	private JTextField texto_sexo;
	private JTextField texto_idade;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					visual_segundo frame = new visual_segundo();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public visual_segundo() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		texto_numero = new JTextField();
		texto_numero.setEnabled(false);
		texto_numero.setBounds(66, 25, 231, 20);
		contentPane.add(texto_numero);
		texto_numero.setColumns(10);
		
		texto_nome = new JTextField();
		texto_nome.setBounds(66, 56, 231, 20);
		contentPane.add(texto_nome);
		texto_nome.setColumns(10);
		
		texto_sexo = new JTextField();
		texto_sexo.setBounds(66, 87, 231, 20);
		contentPane.add(texto_sexo);
		texto_sexo.setColumns(10);
		
		texto_idade = new JTextField();
		texto_idade.setBounds(66, 118, 231, 20);
		contentPane.add(texto_idade);
		texto_idade.setColumns(10);
		
		JLabel lblNewLabel = new JLabel("Numero");
		lblNewLabel.setBounds(10, 28, 46, 14);
		contentPane.add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("Nome");
		lblNewLabel_1.setBounds(10, 59, 46, 14);
		contentPane.add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("Sexo");
		lblNewLabel_2.setBounds(10, 90, 46, 14);
		contentPane.add(lblNewLabel_2);
		
		JLabel lblNewLabel_3 = new JLabel("Idade");
		lblNewLabel_3.setBounds(10, 121, 46, 14);
		contentPane.add(lblNewLabel_3);
		
		Pessoa UmaPessoa = new Pessoa();
		
		JButton btn_ok = new JButton("OK");
		
		btn_ok.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				
				UmaPessoa.setNome(texto_nome.getText());
				UmaPessoa.setSexo(texto_sexo.getText().charAt(0));
				UmaPessoa.setIdade(Integer.parseInt(texto_idade.getText()));
				
				UmaPessoa.setKp();
				
				
			}
		});
		btn_ok.setBounds(10, 203, 89, 23);
		contentPane.add(btn_ok);
		
		JButton btn_limpar = new JButton("Limpar");
		btn_limpar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				texto_nome.setText("");
				texto_sexo.setText("");
				texto_idade.setText("");
				
			}
		});
		btn_limpar.setBounds(109, 203, 89, 23);
		contentPane.add(btn_limpar);
		
		JButton btn_mostrar = new JButton("Mostrar");
		btn_mostrar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				
				System.out.println("Nome: " + UmaPessoa.getNome());
				System.out.println("Sexo: " + UmaPessoa.getSexo());
				System.out.println("Idade: " + UmaPessoa.getIdade());
				System.out.println("Contador KP: " + UmaPessoa.getKp());
				
			}
		});
		btn_mostrar.setBounds(208, 203, 89, 23);
		contentPane.add(btn_mostrar);
		
		JButton btn_sair = new JButton("Sair");
		btn_sair.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				System.exit(0);
				
			}
		});
		btn_sair.setBounds(307, 203, 89, 23);
		contentPane.add(btn_sair);
	}
}
