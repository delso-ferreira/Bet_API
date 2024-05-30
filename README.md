# Bet_API 💰 🎮 ↗️

Esse é um projeto feito no decorrer do curso de desenvolvimento web pela Trybe.

É uma aplicação monolítica desenvolvida com alguns microsserviços separando rotas específicas em uma aplicação separada.

Esse projeto consiste no backend de um site de apostas. Onde, as lógicas  que está pronto, e dividí-lo em microsserviços com determinadas especificidades. O software consiste em uma API responsável por lidar com determinados serviços em um site de apostas de jogos. O software possui 04 entidades (models) principais: Users, Teams, Matches e Bets.

Esta API tem apenas realiza o fluxo inicial de cadasto, permite autenticação, fornecer informações de times e partidas, realizar as apostas e atualiza as odds que são dinâmicas baseadas no valor apostado em cada time. Este site de apostas possui as odds (razão de ganho em uma aposta) atualizadas dinamicamente e não possui fins lucrativos, ou seja, o valor das apostas são inteiramente devolvidos às pessoas usuárias que apostaram.

Fluxos relacionados ao cadastro e atualização de times e partidas, tal como o pagamento de apostas premiadas não são realizados por essa API. Portanto, essas rotas e funcionalidades não existem e não existirão nos microsserviços.

O desenvolvimento dos Dockerfiles de seus microsserviços, tanto como as lógicas nas Controllers, Repository e nos DTO foram feitos por [Delso Ferreira](https://github.com/delso-ferreira) , com foco em CI/DC, para futuramente construir a imagem dos mesmos e ter containers separados para cada microsserviço e um compose da aplicação completa.
