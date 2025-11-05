projeto Login – Atualização

Descrição:
O sistema de login foi desenvolvido em C# com .NET seguindo a arquitetura em camadas e princípios do Domain-Driven Design (DDD).
O objetivo é praticar boas práticas de programação, separação de responsabilidades e agora também o uso de DTOs (Data Transfer Objects) para evitar o acoplamento entre camadas.

Estrutura atual do projeto:

Domain: contém as entidades e exceções personalizadas.

Application: contém os serviços e os DTOs.

Infrastructure: contém o repositório e a parte de acesso aos dados.

Presentation: contém o controller responsável por receber as requisições da API.

Principais funcionalidades:

Cadastro de conta

Login de usuário

Alteração de senha

Validações e exceções específicas para cada caso

Implementação de DTOs para entrada de dados

Mapeamento entre DTOs e entidades de domínio

Atualizações recentes:

Foram criadas as classes ContaCreateDto, ContaLoginDto e AlterarSenhaDto na camada Application.

Cada DTO possui um método Mapear, que transforma os dados recebidos da requisição em uma entidade Conta.

O ContaService passou a receber os DTOs e fazer o mapeamento antes de enviar para o repositório.

O controller foi atualizado para receber os DTOs nas ações, evitando que a entidade de domínio seja exposta.

O código agora está mais desacoplado e segue um padrão mais próximo de aplicações reais em .NET.

Próximos passos:

Criar interfaces para o service e o repository (IContaService e IContaRepository).

Tecnologias utilizadas:

.NET 8

C#

ASP.NET Core Web API

Princípios de Domain-Driven Design (DDD)
