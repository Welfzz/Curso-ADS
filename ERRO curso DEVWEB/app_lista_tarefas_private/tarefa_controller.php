<?php
		
		require "../../app_lista_tarefas_private/tarefa.model.php";
		require "../../app_lista_tarefas_private/tarefa.service.php";
		require "../../app_lista_tarefas_private/conexao.php";

		echo '<pre>';
		print_r($_POST);
		echo '</pre>';


		//criando um objeto de cada classe de cada arquivo privado
		$tarefa = new Tarefa();
		//setando o valor passado pelo formulario para a variavel tarefa atraves do metodo setter da classe TAREFA

		$tarefa->__set('tarefa', $_POST['tarefa']);


		//criando o resto dos objetos de cada classe
		$conexao = new Conexao();
		//o tarefa service controla toda a manipulação de registros, portanto ele precisa receber diretamente a conexão com o DB e tambem a tarefa que será trabalhada
		$tarefaService = new TarefaService($conexao, $tarefa);
		$tarefaService->inserir();



		echo '<pre>';
		print_r($tarefaService);
		echo '</pre>';
?>