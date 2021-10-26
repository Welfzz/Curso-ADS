package base;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;
import java.awt.event.ActionEvent;

public class ViewPrimeiraTela extends JFrame {

	private JPanel contentPane;
	private JTextField textNome;
	private JTextField textIdade;
	private JTextField textEndereco;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ViewPrimeiraTela frame = new ViewPrimeiraTela();
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
	public ViewPrimeiraTela() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		textNome = new JTextField();
		textNome.setBounds(225, 23, 199, 28);
		contentPane.add(textNome);
		textNome.setColumns(10);
		
		textIdade = new JTextField();
		textIdade.setColumns(10);
		textIdade.setBounds(225, 68, 199, 28);
		contentPane.add(textIdade);
		
		textEndereco = new JTextField();
		textEndereco.setColumns(10);
		textEndereco.setBounds(225, 114, 199, 28);
		contentPane.add(textEndereco);
		
		JLabel lblNewLabel = new JLabel("Nome");
		lblNewLabel.setBounds(20, 30, 89, 14);
		contentPane.add(lblNewLabel);
		
		JLabel lblIdade = new JLabel("Idade");
		lblIdade.setBounds(20, 75, 100, 14);
		contentPane.add(lblIdade);
		
		JLabel lblEndereo = new JLabel("Endere\u00E7o");
		lblEndereo.setBounds(20, 121, 100, 14);
		contentPane.add(lblEndereo);
		
		//OK
		
		
		
		List<Aluno> alunos = new ArrayList<>();
		
		JButton btnOK = new JButton("OK");
		btnOK.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
		
				String nome = textNome.getText();
				int idade = Integer.parseInt(textIdade.getText());
				String endereco = textEndereco.getText();
				
				
				
				Aluno insert = new Aluno(nome, idade, endereco);
				
				UUID uuid_valor = UUID.randomUUID();
				
				
				insert.setNome(nome);
				insert.setIdade(idade);
				insert.setEndereco(endereco);
				insert.setUuid(uuid_valor);
				
				alunos.add(insert);
	
				System.out.print(alunos);
			}
		});
		
		
		btnOK.setBounds(20, 216, 89, 23);
		contentPane.add(btnOK);
		
		
		//acao limpar
		JButton btnLimpar = new JButton("Limpar");
		btnLimpar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				textNome.setText("");
				textIdade.setText("");
				textEndereco.setText("");
			}
		});
		
		
		btnLimpar.setBounds(119, 216, 89, 23);
		contentPane.add(btnLimpar);
		
		//mostrar
		JButton btnMostrar = new JButton("Mostrar");
		btnMostrar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				
				for(Aluno dados : alunos) {
					
					
					
					JOptionPane.showMessageDialog(null, "Nome: " + dados.getNome() + " | ID: " + dados.getUuid());
					
				}
				
			}
		});
		
		
		btnMostrar.setBounds(218, 216, 89, 23);
		contentPane.add(btnMostrar);
		
		JButton btnSair = new JButton("Sair");
		btnSair.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.exit(0);
			}
		});
		btnSair.setBounds(317, 216, 89, 23);
		contentPane.add(btnSair);
	}
}
