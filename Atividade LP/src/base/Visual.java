package base;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JScrollPane;
import javax.swing.JSpinner;
import javax.swing.JComboBox;
import javax.swing.JList;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.List;


public class Visual extends JFrame {

	private JPanel contentPane;
	private JTextField textMaximo;
	private JTextField textPriori1;
	private JTextField textPriori2;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Visual frame = new Visual();
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
	public Visual() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblNewLabel = new JLabel("M\u00E1ximo:");
		lblNewLabel.setBounds(26, 24, 61, 14);
		contentPane.add(lblNewLabel);
		
		JLabel lblPrioridade = new JLabel("Prioridade 1:");
		lblPrioridade.setBounds(26, 52, 88, 14);
		contentPane.add(lblPrioridade);
		
		JLabel lblPrioridade_1 = new JLabel("Prioridade 2:");
		lblPrioridade_1.setBounds(26, 79, 88, 14);
		contentPane.add(lblPrioridade_1);
		
		textMaximo = new JTextField();
		textMaximo.setBounds(124, 21, 101, 20);
		contentPane.add(textMaximo);
		textMaximo.setColumns(10);
		
		textPriori1 = new JTextField();
		textPriori1.setColumns(10);
		textPriori1.setBounds(124, 49, 101, 20);
		contentPane.add(textPriori1);
		
		textPriori2 = new JTextField();
		textPriori2.setColumns(10);
		textPriori2.setBounds(124, 76, 101, 20);
		contentPane.add(textPriori2);
		

		List lista1 = new List();
		lista1.setBounds(26, 145, 110, 60);
		contentPane.add(lista1);
		
		List lista2 = new List();
		lista2.setBounds(159, 145, 110, 60);
		contentPane.add(lista2);
		
		
		
		JButton btnIniciar = new JButton("Iniciar");
		btnIniciar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				//iniciar
				Teste thread = new Teste();
				int tm = Integer.parseInt(textMaximo.getText());
				int p1 = Integer.parseInt(textPriori1.getText());
				int p2 = Integer.parseInt(textPriori2.getText());
				
				if(p1 < 0 || p2 > tm) {
					System.out.print("Valores ultrapassam os limites");
					System.exit(0);

				}
				
				thread.setMaximo(tm);
				thread.setPriori1(p1);
				thread.setPriori2(p2);
				
				thread.start();
				
				for(int i = p1; i <= p2; i++ ) {
					
					lista1.add(Integer.toString(i));
					
				}
				
				for(int i = tm; i >= p1; i-- ) {
					
					lista2.add(Integer.toString(i));
					
				}
				
				
				
				
				
				
			}
		});
		btnIniciar.setBounds(92, 116, 101, 23);
		contentPane.add(btnIniciar);
		
		JButton btnLimpar = new JButton("Limpar");
		btnLimpar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				
				lista1.clear();
				lista2.clear();
				textMaximo.setText("");
				textPriori1.setText("");
				textPriori2.setText("");
				
			}
		});
		btnLimpar.setBounds(92, 227, 101, 23);
		contentPane.add(btnLimpar);
		
		JLabel lblFinal = new JLabel("Final");
		lblFinal.setBounds(67, 211, 32, 14);
		contentPane.add(lblFinal);
		
		JLabel lblFinal_1 = new JLabel("Final");
		lblFinal_1.setBounds(203, 212, 32, 14);
		contentPane.add(lblFinal_1);
		
		
		
		
		
		
		
	}
}





