<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%@ page import="java.util.List, br.com.alura.gerenciador.servlet.Produto" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt" %>
    
    
    
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>

	<c:if test="${not empty produto}">
		Produto ${ produto } Cadastrado com sucesso!
	</c:if>
	
	Lista produtos: <br />
	
	<ul>
		<c:forEach items="${produto}" var="produto">
			
			<li>${produto.nome }</li>
			
		</c:forEach>
	</ul>
	
	</ul>

</body>
</html>