<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<c:url value="/novoProduto" var="linkServletNovoProduto" />


<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>

	<form action="${linkServletNovoProduto}" method="post">
		
		Nome: <input type="text" nome="nome" />
		Unidade Compra: <input type="number" nome="unidadeCompra" />
		Descrição: <input type="text" name="descricao" />
		Qtde Prevista Mes: <input type="text" name="qtdePrevistaMes" />
		Preço Max Comprado: <input type="text" name="precoMaxComprado" />
		
		<input type="submit" />
		
	</form>

</body>
</html>