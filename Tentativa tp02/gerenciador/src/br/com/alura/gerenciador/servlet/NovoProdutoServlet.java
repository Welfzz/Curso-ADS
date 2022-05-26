package br.com.alura.gerenciador.servlet;

import java.io.IOException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class NovaEmpresaServlet
 */
@WebServlet("/novoProduto")
public class NovoProdutoServlet extends HttpServlet {
	
	private static final long serialVersionUID = 1L;
	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) 
			throws ServletException, IOException {
		System.out.println("Cadastrando novo produto");
		
		String nomeProduto = request.getParameter("nome");
		
		
		
		Produto produto = new Produto();
		produto.setNome(nomeProduto);
		
		Banco banco = new Banco();
		banco.adiciona(produto);
		
		//chamar o JPS
		RequestDispatcher rd = request.getRequestDispatcher("/novoProdutoCriado.jsp");
		request.setAttribute("produto", produto.getNome());
		rd.forward(request, response);
	}

}

