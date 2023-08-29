var idade
var soma = 0
var n
var contador = 0

for(n = 1; n <= 20; n++){
    idade = parseInt(prompt("Digite um número"))
    soma = soma + idade
    if(idade>=18){
        contador ++
    }
}
alert(contador+ " Pessoas tem   c   v,.nf18 anos ou mais");