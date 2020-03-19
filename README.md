# TesteFCamara
Projeto de teste para FCarama.
Para visualizar o projeto, acessar branch develop devido a um problmea no GIT.


1) EXPLIQUE COM SUAS PALAVRAS O QUE É DOMAIN DRIVEN DESIGN E SUA IMPORTÂNCIA
NA ESTRATÉGIA DE DESENVOLVIMENTO DE SOFTWARE.
É um padrão de projeto(Design Pattern) criado para organizar e facilitar a implementação de software. Sua importância é desacoplar as responsabilidades por camadas.  
Sua importância é a necessidade de criação e manutenção de um domínio rico.

2) EXPLIQUE COM SUAS PALAVRAS O QUE É E COMO FUNCIONA UMA ARQUITETURA BASEADA
EM MICROSERVICES. EXPLIQUE GANHOS COM ESTE MODELO E DESAFIOS EM SUA
IMPLEMENTAÇÃO.
A arquitetura de microserviços tem com definição ser uma parte pequena de uma solução altamente especializada, que seja responsável por determinadas partes do projeto. Cada microserviço pode ter sua própria tecnologia o que gera um ganho para determinados desafios de uma equipe. A grande vantagem de trabalhar com esse modelo é escalabilidade, é possível escalar um ponto especifico que necessita por algum motivo sazonal naquele momento precisar de mais recursos. O grande desafio é manter integro as informações, por isso ao meu ver é recomendação realizar juntamente com essa arquitetura um arquitetura de resiliência, como por exemplo Polly.

3) EXPLIQUE QUAL A DIFERENÇA ENTRE COMUNICAÇÃO SINCRONA E ASSINCRONA E QUAL O
MELHOR CENÁRIO PARA UTILIZAR UMA OU OUTRA.

Comunicação síncrona é a necessidade de resposta direta, e assíncrona é a comunicação onde o server responde para o client assim que for possível.
Um exemplo que gosto de usar para explicar assíncrona é o Whatsapp, se você me manda um mensagem e meu celular está sem internet ela só chega para mim assim que me conectar, ou seja a mensagem fica no servidor aguardando o cliente. 
Para o exemplo	 de síncrona podemos colocar a chamada de vídeo, ou seja essa comunicação acontece na mesma hora, sem precisar esperar o servidor se comunicar com o cliente.

