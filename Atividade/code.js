

function recebeNum(){

	//captura o valor digitado pelo usuário
	let valor = document.getElementById('roman').value
	//apaga o valor digitado após recuperá-lo
	document.getElementById('roman').value = ''

	//array com so valores romanos e arábicos respectivamente, sem espaçamentos
	let lista_rom = {M:1000,CM:900,D:500,CD:400,C:100,XC:90,L:50,XL:40,X:10,IX:9,V:5,IV:4,I:1}

	//variável que receberá os valores romanos correspondentes
	let valores_romanos = ''
	
	let valor_string = valor.toString().toUpperCase()
	//console.log("String valor: ",valor_string)

	//verifica as limitações
	if(!(valor <= 0 || valor > 3999)){


		//a partir daqui, o códico percorrerá todo o array verificando se o valor digitado pelo usuário é maior ou igual ao elemento na posição atual, caso seja, o valor em numero romano será adicionado a váriavel e o numero correspondente que foi digitado sera removido, e o laço se repete.

		for(let chave in lista_rom){

			while(valor >= lista_rom[chave]){
				valores_romanos = valores_romanos + chave

				console.log("valor chave: ",lista_rom[chave])

				valor = valor - lista_rom[chave]
			}
		}
	
	}else{
		valores_romanos = 'Valor Incompatível'
	}

	document.getElementById('resultadoConversaoRom').innerHTML = "Conversão Romana: " + valores_romanos

	//verificando se os valores não se repetem em excesso
	if(!(valor_string.split("X").length > 4 || valor_string.split("I").length > 4 || valor_string.split("V").length > 4 ||  valor_string.split("C").length > 4 || valor_string.split("L").length > 4 || valor_string.split("D").length > 4 || valor_string.split("M").length > 4)){

		let chave2 = {I : 1, V : 5, X : 10, L : 50, C : 100, D : 500, M : 1000}
	    let valores_arabicos = []

	    for(let i=0; i<valor_string.length; i++){

	        if (chave2[valor_string[i]]<chave2[valor_string[i+1]]){
	        	//subtrai caso o valor a direita do valor string for maior que o valor atual, isso é feito atraves do indice de cada caractere do valor string, representado por i
	            valores_arabicos.push(chave2[valor_string[i+1]] - chave2[valor_string[i]]);
	            i++;
	            continue;

		     }else{
	        	//caso contrário, adiciona no array o valor
	            valores_arabicos.push(chave2[valor_string[i]])
	        }
	    }
	    //função que reduz elementos de um array para retornar apenas um resultado
	    let resp = valores_arabicos.reduce((prev,current) => current+prev)

	    if(resp == undefined || isNaN(resp)){
	    	document.getElementById("resultadoConversaoAra").innerHTML = "Conversão Arabica: "
	    }else{
	    	document.getElementById("resultadoConversaoAra").innerHTML = "Conversão Arabica: "+ resp
	    }

	}else{
		document.getElementById("resultadoConversaoAra").innerHTML = "Conversão Arabica: Valor Incompatível"
	}


}
	



function recebeQTD(){
	//on click - executa o programa

	let numPessoas = document.getElementById('QTD').value
	document.getElementById('QTD').value = ''

	document.getElementById('QTD').setAttribute('disabled', 'disabled')
	document.getElementById('env').setAttribute('disabled', 'disabled')



	for(let i=0; i < numPessoas ; i++){

		let label = document.createElement('label')
		let textoLabel = document.createTextNode("Entre com o " + (i+1) + "º nome: ")
		var quebra = document.createElement('br')
		let inputNovo = document.createElement('input')

		label.appendChild(textoLabel)

		document.getElementById('divCalculadora').appendChild(label)
		document.getElementById('divCalculadora').appendChild(inputNovo)
		inputNovo.setAttribute('id', i)

		document.getElementById('divCalculadora').appendChild(quebra)


		console.log("i: ", i)
		console.log("numP: ", numPessoas)


	}

	document.getElementById('divCalculadora').appendChild(quebra)

	let nomes = []
	

	let btn1 = document.createElement('button')
	let textoBtn = document.createTextNode("Enviar Nomes")

	document.getElementById('divCalculadora').appendChild(btn1)
	document.getElementById('divCalculadora').appendChild(quebra)
	btn1.appendChild(textoBtn)
	btn1.setAttribute('type', 'button')
	btn1.setAttribute('id', 'btn_enviaPessoas')


	document.getElementById('divCalculadora').appendChild(quebra)
	

	btn1.onclick = function(){

		let soma_individual = []
		let produtos = ["PIZZA", "REFRIGERANTE", "SUCO"]


		for(let j = 0; j < numPessoas; j++){

				nomes.push(document.getElementById(j).value)
				console.log(nomes)
		}


		document.getElementById('btn_enviaPessoas').setAttribute('disabled', 'disabled')
		document.getElementById('divCalculadora').appendChild(quebra)




		for(let i=0; i<numPessoas;i++){


			let label = document.createElement('label')
			let textoLabel = document.createTextNode("Quais produtos foram consumidos por "+ nomes[i] + ": ")
			let inputNovo2 = document.createElement('input')

			label.appendChild(textoLabel)


			document.getElementById('divCalculadora').appendChild(label)
			document.getElementById('divCalculadora').appendChild(inputNovo2)
			inputNovo2.setAttribute('id', i)



			let btn2 = document.createElement('button')
			let textoBtn = document.createTextNode("Add")



			document.getElementById('divCalculadora').appendChild(btn2)
			btn2.appendChild(textoBtn)
			btn2.setAttribute('type', 'button')
			btn2.setAttribute('id', i)


			document.getElementById('divCalculadora').appendChild(quebra)
			


			btn2.onclick = function(){

				

					document.getElementById('divCalculadora').appendChild(quebra)
						if(produtos.includes(inputNovo2.value.toUpperCase())){

									switch(inputNovo2.value.toUpperCase()){

									case "PIZZA":
										soma_individual.push(42)
										break;

									case "REFRIGERANTE":
										soma_individual.push(8)
										break;

									case "SUCO":
										soma_individual.push(7)
										break;
							}

							console.log(soma_individual)
						
						}else{
							alert("Produto não fornecido!")
						}

						var total = 0

						for(let j in soma_individual){
							total = total + soma_individual[j]
						}

						

						inputNovo2.value = ''

						console.log(total)
						
						let pResp = document.createElement('p')
						document.getElementById('divCalculadora').appendChild(pResp)

						pResp.innerHTML = "Valor total a pagar: R$" + total


						document.getElementById('divCalculadora').appendChild(quebra)

			}		
				

		}

			





	}


		

	



	





	

	

	

}

