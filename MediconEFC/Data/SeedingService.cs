using MediconEFC.Models;
using MediconEFC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Data
{
    public class SeedingService
    {
        private MediconEFCContext _context;

        public SeedingService(MediconEFCContext context)
        {
            _context = context;
        }

        public void Seed()
        {

            ///////=============================> Tabelas tipos <=============================
            List<AbrangenciaPlano> abrangenciaPlanos = new List<AbrangenciaPlano>
            {
                ////new AbrangenciaPlano(){Id= 1,Nome="Municipal"  },
                ////new AbrangenciaPlano(){Id= 2,Nome="Estadual"  },
                ////new AbrangenciaPlano(){Id= 3,Nome="Nacional"  },
                ////new AbrangenciaPlano(){Id= 4,Nome="Internacional"  }

                new AbrangenciaPlano(){Nome="Municipal"  },
                new AbrangenciaPlano(){Nome="Estadual"  },
                new AbrangenciaPlano(){Nome="Nacional"  },
                new AbrangenciaPlano(){Nome="Internacional"  }
            };


            List<TipoAcomodacao> tipoAcomodacaos = new List<TipoAcomodacao>
            {
                ////new TipoAcomodacao(){ Id=1,Nome="QuartoColetivo" },
                ////new TipoAcomodacao(){ Id=2,Nome="QuartoIndicidual" },
                ////new TipoAcomodacao(){ Id=3,Nome="Apartamento" },
                ////new TipoAcomodacao(){ Id=4,Nome="Enfermaria" },
                

                new TipoAcomodacao(){ Nome="QuartoColetivo" },
                new TipoAcomodacao(){ Nome="QuartoIndicidual" },
                new TipoAcomodacao(){ Nome="Apartamento" },
                new TipoAcomodacao(){ Nome="Enfermaria" },
            };

            List<TipoContrato> tipoContratos = new List<TipoContrato>
            {
                //new TipoContrato(){ Id =1 , Nome="Particular"},
                //new TipoContrato(){ Id =2 , Nome="Empresarial"},
                //new TipoContrato(){ Id =3 , Nome="Associacao"},
                //new TipoContrato(){ Id =4 , Nome="EntidadeDeClasse"},

                new TipoContrato(){ Nome="Particular"},
                new TipoContrato(){ Nome="Empresarial"},
                new TipoContrato(){ Nome="Associacao"},
                new TipoContrato(){ Nome="EntidadeDeClasse"},
            };

            List<TipoPlano> tipoPlanos = new List<TipoPlano>
            {
                ////new TipoPlano(){Id=1 , Nome="Individual" },
                ////new TipoPlano(){Id=2 , Nome="Familiar" },
                ////new TipoPlano(){Id=3 , Nome="Adesão" },
                ////new TipoPlano(){Id=4 , Nome="Empresarial" },

                new TipoPlano(){Nome="Individual" },
                new TipoPlano(){Nome="Familiar" },
                new TipoPlano(){Nome="Adesão" },
                new TipoPlano(){Nome="Empresarial" },
            };

            ///////=============================> Lista de planos <=============================
            List<Plano> ListaPlano = new List<Plano>
            {
                new Plano(){ Nome ="Medicon Saúde" },
                new Plano(){ Nome ="Sancil" },
                new Plano(){ Nome ="DixSaúde" },
                new Plano(){ Nome ="Ameplan" },
                new Plano(){ Nome ="Biosaude" },
                new Plano(){ Nome ="Medical Health" },
                new Plano(){ Nome ="Plena Saúde" },
                new Plano(){ Nome ="Porto Seguro Saúde" },
                new Plano(){ Nome ="Samed Plano de Saúde" },
                new Plano(){ Nome ="Santa Casa de Mauá Plano de Saúde" },
                new Plano(){ Nome ="Santa Helena Saúde" },
                new Plano(){ Nome ="Santa Helena Saúde" },
                new Plano(){ Nome ="Santamalia Saúde" },
                new Plano(){ Nome ="Seguros Unimed" },
                new Plano(){ Nome ="Sul América" },
                new Plano(){ Nome ="Unimed Fesp" },
                new Plano(){ Nome ="Allianz seguros saude" },
                new Plano(){ Nome ="Amil" },
                new Plano(){ Nome ="BIOVIDA SAÚDE LTDA" },
                new Plano(){ Nome ="Samed Saúde 2017" },
                new Plano(){ Nome ="Saúde Mogi" }
            };

            ////=============================> Lista dede mensagens <=============================
            List<Mensagem> listaMesagem = new List<Mensagem>
            {
                new Mensagem(){ Numero =900,Segla ="msg900",Decricao="Desculpe, ocorreu um erro.",Tipo="Erro"},
                new Mensagem(){ Numero =100,Segla ="msg100",Decricao="Plano alterado com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =101,Segla ="msg101",Decricao="Deseja realmente alterar plano?",Tipo="Alerta"},
                new Mensagem(){ Numero =105,Segla ="msg105",Decricao="Erro ao tentar realizar alteração do plano!",Tipo="Erro"},
                new Mensagem(){ Numero =102,Segla ="msg102",Decricao="Erro ao tentar excluir plano!",Tipo="Erro"},
                new Mensagem(){ Numero =103,Segla ="msg103",Decricao="Plano excluído com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =104,Segla ="msg104",Decricao="Plano não encontrado.",Tipo="Alerta"},
                new Mensagem(){ Numero =106,Segla ="msg106",Decricao="Deseja realmente excluir o plano?",Tipo="Alerta"},
                new Mensagem(){ Numero =107,Segla ="msg107",Decricao="Plano cadastrado com sucesso.",Tipo="Sucesso"},
                new Mensagem(){ Numero =108,Segla ="msg108",Decricao="Erro ao tentar cadastrar plano.",Tipo="Erro"},
                new Mensagem(){ Numero =109,Segla ="msg109",Decricao="Plano já cadastrado no sistema?",Tipo="Alerta"},
                new Mensagem(){ Numero =110,Segla ="msg110",Decricao="Equipe cadastrada com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =111,Segla ="msg111",Decricao="Deseja realmente alterar equipe?",Tipo="Alerta"},
                new Mensagem(){ Numero =112,Segla ="msg112",Decricao="Erro ao tentar realizar alteração da equipe!",Tipo="Erro"},
                new Mensagem(){ Numero =113,Segla ="msg113",Decricao="Erro ao tentar excluir equipe!",Tipo="Erro"},
                new Mensagem(){ Numero =114,Segla ="msg114",Decricao="Equipe excluída com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =115,Segla ="msg115",Decricao="Equipe não encontrada.",Tipo="Alerta"},
                new Mensagem(){ Numero =116,Segla ="msg116",Decricao="Deseja realmente excluir a equipe?",Tipo="Alerta"},
                new Mensagem(){ Numero =117,Segla ="msg117",Decricao="Equipe alterada com sucesso.",Tipo="Sucesso"},
                new Mensagem(){ Numero =118,Segla ="msg118",Decricao="Erro ao tentar cadastrar equipe.",Tipo="Erro"},
                new Mensagem(){ Numero =119,Segla ="msg119",Decricao="Equipe já cadastrada no sistema?",Tipo="Alerta"},
                new Mensagem(){ Numero =120,Segla ="msg120",Decricao="Corretor alterado com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =121,Segla ="msg121",Decricao="Deseja realmente alterar corretor?",Tipo="Alerta"},
                new Mensagem(){ Numero =122,Segla ="msg122",Decricao="Erro ao tentar realizar alteração do corretor!",Tipo="Erro"},
                new Mensagem(){ Numero =123,Segla ="msg123",Decricao="Erro ao tentar excluir corretor!",Tipo="Erro"},
                new Mensagem(){ Numero =124,Segla ="msg124",Decricao="Corretor excluído com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =125,Segla ="msg125",Decricao="Corretor não encontrado.",Tipo="Alerta"},
                new Mensagem(){ Numero =126,Segla ="msg126",Decricao="Deseja realmente excluir o corretor!",Tipo="Alerta"},
                new Mensagem(){ Numero =127,Segla ="msg127",Decricao="Corretor cadastrado com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =128,Segla ="msg128",Decricao="Erro ao tentar cadastrar corretor.",Tipo="Erro"},
                new Mensagem(){ Numero =129,Segla ="msg129",Decricao="Corretor já cadastrado no sistema?",Tipo="Alerta"},
                new Mensagem(){ Numero =130,Segla ="msg130",Decricao="Corretor cadastrado com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =131,Segla ="msg131",Decricao="Cliente alterado com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =132,Segla ="msg132",Decricao="Deseja realmente alterar Cliente?",Tipo="Alerta"},
                new Mensagem(){ Numero =141,Segla ="msg141",Decricao="Erro ao tentar realizar alteração do Cliente!",Tipo="Erro"},
                new Mensagem(){ Numero =133,Segla ="msg133",Decricao="Erro ao tentar excluir Cliente!",Tipo="Erro"},
                new Mensagem(){ Numero =134,Segla ="msg134",Decricao="Cliente excluído com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =135,Segla ="msg135",Decricao="Cliente não encontrado.",Tipo="Alerta"},
                new Mensagem(){ Numero =136,Segla ="msg136",Decricao="Deseja realmente excluir o Cliente!",Tipo="Alerta"},
                new Mensagem(){ Numero =137,Segla ="msg137",Decricao="Cliente cadastrado com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =138,Segla ="msg138",Decricao="Erro ao tentar cadastrar Cliente.",Tipo="Erro"},
                new Mensagem(){ Numero =139,Segla ="msg139",Decricao="Cliente já cadastrado no sistema?",Tipo="Alerta"},

                new Mensagem(){ Numero =140,Segla ="msg140",Decricao="Cliente cadastrado com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =141,Segla ="msg141",Decricao="Erro ao tentar realizar alteração do Cliente!",Tipo="Erro"},
                new Mensagem(){ Numero =142,Segla ="msg142",Decricao="Deseja realmente alterar faixa etária?",Tipo="Alerta"},
                new Mensagem(){ Numero =143,Segla ="msg143",Decricao="Faixa etária não encontrada.",Tipo="Alerta"},
                new Mensagem(){ Numero =144,Segla ="msg144",Decricao="Faixa etária excluída com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =145,Segla ="msg145",Decricao="Deseja realmente excluir a faixa etária!",Tipo="Alerta"},
                new Mensagem(){ Numero =146,Segla ="msg146",Decricao="Faixa etária cadastrada com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =147,Segla ="msg147",Decricao="Erro ao tentar cadastrar faixa etária.",Tipo="Erro"},
                new Mensagem(){ Numero =148,Segla ="msg148",Decricao="Faixa etária já cadastrada no sistema?",Tipo="Alerta"},
                new Mensagem(){ Numero =149,Segla ="msg149",Decricao="Erro ao tentar realizar alteração da faixa etária!",Tipo="Erro"},
                new Mensagem(){ Numero =150,Segla ="msg150",Decricao="Erro ao tentar excluir faixa etária!",Tipo="Erro"},
                new Mensagem(){ Numero =151,Segla ="msg151",Decricao="Deseja realmente alterar dependente?",Tipo="Alerta"},
                new Mensagem(){ Numero =152,Segla ="msg152",Decricao="Dependente não encontrado.",Tipo="Alerta"},
                new Mensagem(){ Numero =153,Segla ="msg153",Decricao="Dependente excluído com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =154,Segla ="msg154",Decricao="Deseja realmente excluir o dependente!",Tipo="Alerta"},
                new Mensagem(){ Numero =155,Segla ="msg155",Decricao="Dependente cadastrado com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =156,Segla ="msg156",Decricao="Erro ao tentar cadastrar dependente.",Tipo="Erro"},
                new Mensagem(){ Numero =157,Segla ="msg157",Decricao="Dependente já cadastrado no sistema?",Tipo="Alerta"},
                new Mensagem(){ Numero =158,Segla ="msg158",Decricao="Erro ao tentar realizar alteração do dependente!",Tipo="Erro"},
                new Mensagem(){ Numero =159,Segla ="msg159",Decricao="Erro ao tentar excluir dependente!",Tipo="Erro"},
                new Mensagem(){ Numero =160,Segla ="msg160",Decricao="Dependente alterado com sucesso!",Tipo="Sucesso"},
                new Mensagem(){ Numero =161,Segla ="msg161",Decricao="Faixa etária alterada com sucesso!",Tipo="Sucesso"},
            };

            ////=============================> Corretor <=============================
            List<Corretor> listaCorretor = new List<Corretor>
            {
                new Corretor(){ Nome ="Carlos", Telefone="(73)11111-1111", Ativo=true},
                new Corretor(){ Nome ="Aline", Telefone="(73)11111-1111", Ativo=true},
                new Corretor(){ Nome ="Antônio dos Santos Amoro", Telefone="(73)11111-1111", Ativo=true},
                new Corretor(){ Nome ="José dos Santos Campinas", Telefone="(73)11111-1111", Ativo=true},
                new Corretor(){ Nome ="Mariana", Telefone="(73)11111-1111", Ativo=true},
                new Corretor(){ Nome ="Janaina",  Telefone="(73)11111-1111",Ativo=true},
                new Corretor(){ Nome ="Edvan", Telefone="(73)11111-1111", Ativo=true},

            };

            ///////=============================> Equipe <=============================
            List<Equipe> listaEquiepe = new List<Equipe>
            {
                new Equipe (){ Nome ="Mogi das Cruzes", Telefone = "(11)4747-4717", Contato = "Teste", Ativo = true, CorretorId = 1 },
                new Equipe (){ Nome ="São Paulo", Telefone = "(11)5656-5656", Contato = "José", Ativo = true, CorretorId = 2 },
                new Equipe (){ Nome ="Campinas", Telefone = "(19)3333-3333", Contato = "Maria", Ativo = true, CorretorId = 3 },
                new Equipe (){ Nome ="Santo Amaro", Telefone = "(11)5454-5454", Contato = "Santo", Ativo = true, CorretorId = 4 },
                new Equipe (){ Nome ="Santos", Telefone = "(11)5454-5454", Contato = "Santos", Ativo = true, CorretorId = 5 },
                new Equipe (){ Nome ="Equipe cadastro teste", Telefone = "(11)5555-5555", Contato = "Responsável teste", Ativo = true, CorretorId = 6 },
                new Equipe (){ Nome ="Teste ativo Update", Telefone = "(11)5555-5555", Contato = "Teste ativo", Ativo = true, CorretorId = 7 },
                new Equipe (){ Nome ="Teste ativo update", Telefone = "(11)5555-5555", Contato = "Teste ativo", Ativo = true, CorretorId = 1 },
                new Equipe (){ Nome ="Equipe teste tela", Telefone = "(11)5555-5555", Contato = "Equipe teste tela", Ativo = true, CorretorId = 2 },
                new Equipe (){ Nome ="Vasco", Telefone = "(11)5555-5555", Contato = "Vasco da gama", Ativo = true, CorretorId = 3 },
                new Equipe (){ Nome ="Trem bala da colina", Telefone = "1154544545", Contato = "Teste", Ativo = true, CorretorId = 4 },
                new Equipe (){ Nome ="Teste 2017 02", Telefone = "1123233311", Contato = "dsadasd", Ativo = true, CorretorId = 5 },
                new Equipe (){ Nome ="Teste mask", Telefone = "(11) 95654-4444", Contato = "Teste Mask", Ativo = true, CorretorId = 6 },
                new Equipe (){ Nome ="Suzano", Telefone = "1154544545", Contato = "Suzane", Ativo = true, CorretorId = 7 },
                new Equipe (){ Nome ="Jaguaquara", Telefone = "(73) 1111-1111", Contato = "Entroncamento de Jaguaquara fdsfdsfsd", Ativo = true, CorretorId = 1 },

                ////new Equipe (){ Nome ="Mogi das Cruzes", Telefone = "(11)4747-4717", Contato = "Teste", Ativo = true, CorretorId = 9 },
                ////new Equipe (){ Nome ="São Paulo", Telefone = "(11)5656-5656", Contato = "José", Ativo = true, CorretorId = 10 },
                ////new Equipe (){ Nome ="Campinas", Telefone = "(19)3333-3333", Contato = "Maria", Ativo = true, CorretorId = 11 },
                ////new Equipe (){ Nome ="Santo Amaro", Telefone = "(11)5454-5454", Contato = "Santo", Ativo = true, CorretorId = 12 },
                ////new Equipe (){ Nome ="Santos", Telefone = "(11)5454-5454", Contato = "Santos", Ativo = true, CorretorId = 13 },
                ////new Equipe (){ Nome ="Equipe cadastro teste", Telefone = "(11)5555-5555", Contato = "Responsável teste", Ativo = true, CorretorId = 14 },
                ////new Equipe (){ Nome ="Teste ativo Update", Telefone = "(11)5555-5555", Contato = "Teste ativo", Ativo = true, CorretorId = 15 },
                ////new Equipe (){ Nome ="Teste ativo update", Telefone = "(11)5555-5555", Contato = "Teste ativo", Ativo = true, CorretorId = 9 },
                ////new Equipe (){ Nome ="Equipe teste tela", Telefone = "(11)5555-5555", Contato = "Equipe teste tela", Ativo = true, CorretorId = 10 },
                ////new Equipe (){ Nome ="Vasco", Telefone = "(11)5555-5555", Contato = "Vasco da gama", Ativo = true, CorretorId = 11 },
                ////new Equipe (){ Nome ="Trem bala da colina", Telefone = "1154544545", Contato = "Teste", Ativo = true, CorretorId = 12 },
                ////new Equipe (){ Nome ="Teste 2017 02", Telefone = "1123233311", Contato = "dsadasd", Ativo = true, CorretorId = 13 },
                ////new Equipe (){ Nome ="Teste mask", Telefone = "(11) 95654-4444", Contato = "Teste Mask", Ativo = true, CorretorId = 14 },
                ////new Equipe (){ Nome ="Suzano", Telefone = "1154544545", Contato = "Suzane", Ativo = true, CorretorId = 15 },
                ////new Equipe (){ Nome ="Jaguaquara", Telefone = "(73) 1111-1111", Contato = "Entroncamento de Jaguaquara fdsfdsfsd", Ativo = true, CorretorId = 9 },
            };

            ///////=============================> Cliente <=============================
            List<Cliente> listaCliente = new List<Cliente>
                {

                    new Cliente(){ Nome ="Cliente Teste 01 update 02",Cpf ="88414532144",Cep="1001001",Endereco="Praça da Sé", Numero =1,Complemento ="Centro",Bairro="Praça da Sé",Cidade="São Paulo", Estado ="SP",Telefone ="(11)2121-2121",Celular="(11)99999-9999",Email="Teste@cliente.com", Observacao ="Este é um cliente teste",Ativo =true},
                    new Cliente(){ Nome ="Cliente teste 2017 update",Cpf ="43654474322",Cep="01007-040",Endereco="Parque Anhangabaú", Numero =1,Complemento ="Apartamento",Bairro="Centro",Cidade="São paulo", Estado ="SP",Telefone ="(11)0101-0101",Celular="(11)90101-0101",Email="teste@teste.com", Observacao ="Favor desconsiderar as informações contida neste cadastro apenas para testar as funcionalidades do sistema!Obrigado.",Ativo = true},
                    new Cliente(){ Nome ="Maria",Cpf ="43654474329",Cep="01007-050",Endereco="Endereço da MAria", Numero =101,Complemento ="Casa",Bairro="Bairro da Maria",Cidade="Cidade da Maria", Estado ="Estado da Maria",Telefone ="(11)0101-0109",Celular="(11)90101-0109",Email="Emaildamaria@gmail.com", Observacao ="Cadastro teste 03/10/2018", Ativo = true},
                    new Cliente(){ Nome ="Cliente Teste 2018",Cpf ="111.111.111-11",Cep="11111-111",Endereco="Teste 2018", Numero =1,Complemento ="Complementto Teste 2018",Bairro="Bairro Teste 2018",Cidade="São Pedro", Estado ="SP",Telefone ="(11) 1111-1111",Celular="(11) 11111-1111",Email="teste@teste.com", Observacao ="Teste 2018 cadastro",Ativo =true},
                    new Cliente(){ Nome ="Teste 2018 02",Cpf ="122.222.222-22",Cep="22222-222",Endereco="Teste 2018 02", Numero =1,Complemento ="Complemento Teste 2018 02",Bairro="bairro Teste 2018 02",Cidade="Campinas", Estado ="SP",Telefone ="(11) 1111-1111",Celular="(11) 11111-1111",Email="teste@teste.com", Observacao ="Obs: Teste 2018 02 ",Ativo =true},
                    new Cliente(){ Nome ="Cliente 03",Cpf ="333.333.333-33",Cep="33333-333",Endereco="Cliente 03", Numero =3,Complemento ="Complemento Cliente 03",Bairro="Bairro Cliente 03",Cidade="São paulo", Estado ="SP",Telefone ="(33) 3333-3333",Celular="(33) 33333-3333",Email="teste@teste.com", Observacao ="Obs: Cliente 03 ",Ativo =true},
                    new Cliente(){ Nome ="Cliente 04",Cpf ="444.444.444-44",Cep="44444-444",Endereco="Cliente 04", Numero =4,Complemento ="Cliente 04",Bairro="Cliente 04",Cidade="São paulo", Estado ="SP",Telefone ="(44) 4444-4444",Celular="(44) 44444-4444",Email="teste@teste.com", Observacao ="Obs: Cliente 04",Ativo =true},
                };

            ///////=============================> FaixaEtaria <=============================
            List<FaixaEtaria> listafaixaEtaria = new List<FaixaEtaria>
                {
                    new FaixaEtaria(){ Descricao ="00 a 09", Ativo=true},
                    new FaixaEtaria(){ Descricao ="10 a 14", Ativo=true},
                    new FaixaEtaria(){ Descricao ="15 a 18 ", Ativo=true},
                    new FaixaEtaria(){ Descricao ="19 a 28", Ativo=true},
                    new FaixaEtaria(){ Descricao ="29 a 33", Ativo=true},
                    new FaixaEtaria(){ Descricao ="30 a 38", Ativo=true},
                    new FaixaEtaria(){ Descricao ="39 a 43", Ativo=true},
                    new FaixaEtaria(){ Descricao ="44 a 48", Ativo=true},
                    new FaixaEtaria(){ Descricao ="49 a 53", Ativo=true},
                    new FaixaEtaria(){ Descricao ="54 a 58", Ativo=true},
                    new FaixaEtaria(){ Descricao ="59 ou Mais", Ativo=true},
                };


            ///////=============================> PrecoPlano <=============================
            List<PrecoPlano> listaPrecoPlano = new List<PrecoPlano>
                {
                    //new PrecoPlano(){ FaixaEtariaId=12,TipoAcomodacaoId= 1 , AbrangenciaPlanoId =1, TipoContratoId = 1, TipoPlanoId = 1, Valor=   98.00,Observacao=" OBS. Teste 01", Ativo= true},
                    //new PrecoPlano(){ FaixaEtariaId=13,TipoAcomodacaoId= 2 , AbrangenciaPlanoId = 3, TipoContratoId = 2, TipoPlanoId = 2, Valor=   250.00,Observacao=" OBS. Teste 02", Ativo= true},
                    //new PrecoPlano(){ FaixaEtariaId=14,TipoAcomodacaoId= 3 , AbrangenciaPlanoId = 3, TipoContratoId = 3, TipoPlanoId =3, Valor=   310.00,Observacao=" OBS. Teste 03", Ativo= true},
                    //new PrecoPlano(){ FaixaEtariaId=15,TipoAcomodacaoId= 4 , AbrangenciaPlanoId = 4, TipoContratoId = 4, TipoPlanoId = 4, Valor=   500.00,Observacao=" OBS. Teste 04", Ativo= true},

                    new PrecoPlano(){ FaixaEtariaId=1,TipoAcomodacaoId= 1 , AbrangenciaPlanoId =1, TipoContratoId = 1, TipoPlanoId = 1, Valor=   98.00,Observacao=" OBS. Teste 01", Ativo= true},
                    new PrecoPlano(){ FaixaEtariaId=2,TipoAcomodacaoId= 2 , AbrangenciaPlanoId = 3, TipoContratoId = 2, TipoPlanoId = 2, Valor=   250.00,Observacao=" OBS. Teste 02", Ativo= true},
                    new PrecoPlano(){ FaixaEtariaId=3,TipoAcomodacaoId= 3 , AbrangenciaPlanoId = 3, TipoContratoId = 3, TipoPlanoId =3, Valor=   310.00,Observacao=" OBS. Teste 03", Ativo= true},
                    new PrecoPlano(){ FaixaEtariaId=4,TipoAcomodacaoId= 4 , AbrangenciaPlanoId = 4, TipoContratoId = 4, TipoPlanoId = 4, Valor=   500.00,Observacao=" OBS. Teste 04", Ativo= true},
                };

            ///////=============================> Dependente <=============================

            List<Dependente> listaDependente = new List<Dependente>
                {
                  new Dependente(){ Nome="Dependente 01", Cpf="710.731.301-00"},
                  new Dependente(){ Nome="Dependente 02", Cpf="345.252.733-64"},
                  new Dependente(){ Nome="Dependente 03", Cpf="479.352.928-33"},
                  new Dependente(){ Nome="Dependente 04", Cpf="494.585.947-74"}
                };

            ///////=============================> Proposta <=============================
            List<Proposta> listaProposta = new List<Proposta>
                {
                //new Proposta(){ NomeProsposta="Proposta 01",  DataProposta= new DateTime(2017,11,10,23,59,59), ClienteId= 8, PlanoId= 1,CorretorId= 1 ,PrecoPlanoId=1 ,Valor= 98.00 , DependenteId =1, Ativo= true },
                //new Proposta(){ NomeProsposta="Proposta 02", DataProposta= new DateTime(2018,02,03,23,59,59), ClienteId= 9, PlanoId= 2,CorretorId= 2 ,PrecoPlanoId=2 ,Valor= 250.00 , DependenteId =2,Ativo= true },
                //new Proposta(){ NomeProsposta="Proposta 03", DataProposta= new DateTime(2018,05,13,23,59,59), ClienteId= 10, PlanoId= 3,CorretorId= 3 ,PrecoPlanoId=3 ,Valor= 310.00 ,DependenteId =3, Ativo= true },
                //new Proposta(){ NomeProsposta="Proposta 04", DataProposta= new DateTime(2018,10,02,23,59,59), ClienteId= 11, PlanoId= 4,CorretorId= 4 ,PrecoPlanoId=4 ,Valor= 500.00 ,DependenteId =4, Ativo= true }

                new Proposta(){ NomeProsposta="Proposta 01",  DataProposta= new DateTime(2017,11,10,23,59,59), ClienteId= 1, PlanoId= 1,CorretorId= 1 ,PrecoPlanoId=1 ,Valor= 98.00 , DependenteId =1, Ativo= true },
                new Proposta(){ NomeProsposta="Proposta 02", DataProposta= new DateTime(2018,02,03,23,59,59), ClienteId= 2, PlanoId= 2,CorretorId= 2 ,PrecoPlanoId=2 ,Valor= 250.00 , DependenteId =2,Ativo= true },
                new Proposta(){ NomeProsposta="Proposta 03", DataProposta= new DateTime(2018,05,13,23,59,59), ClienteId= 3, PlanoId= 3,CorretorId= 3 ,PrecoPlanoId=3 ,Valor= 310.00 ,DependenteId =3, Ativo= true },
                new Proposta(){ NomeProsposta="Proposta 04", DataProposta= new DateTime(2018,10,02,23,59,59), ClienteId= 4, PlanoId= 4,CorretorId= 4 ,PrecoPlanoId=4 ,Valor= 500.00 ,DependenteId =4, Ativo= true }

            };


            /*=============================================Ereror: ===================================================
             * Cannot open database "MediconEFCContext" requested by the login. The login failed.
             * Esso ocorre se o BD foi apagado e a "1° Etapa" tiver retirar comentário ele vai tentar acessar a tabela, mas o banco não existe,
             * Comentar todas as etapas IN PACKGE MANAGER CONSOLE "Update-Database "para criar o banco depois retirar comentário conforme a definições das etapas abaixo
              =============================================Ereror: ===================================================*/

            /*=============================================OBS: ===================================================
             * Para gravar a massa de dados na base precisa seguir está sequencia porque e arrumar o “ID FK" das listas de porque 
             * nem sempre gravar na sequencia certa 123 ec. Fazer por etapas e consultando o Id para ir alterando as lista acima
             * =============================================OBS: ===================================================*/

            ////================================1° Etapa============
            if (!_context.AbrangenciaPlano.Any())
                _context.AbrangenciaPlano.AddRange(abrangenciaPlanos);
            if (!_context.TipoAcomodacao.Any())
                _context.TipoAcomodacao.AddRange(tipoAcomodacaos);
            if (!_context.TipoContrato.Any())
                _context.TipoContrato.AddRange(tipoContratos);
            if (!_context.TipoPlano.Any())
                _context.TipoPlano.AddRange(tipoPlanos);
            if (!_context.Mensagem.Any())
                _context.Mensagem.AddRange(listaMesagem);
            if (!_context.Plano.Any())
                _context.Plano.AddRange(ListaPlano);
            if (!_context.Corretor.Any())
                _context.Corretor.AddRange(listaCorretor);
            //////////================================2° Etapa============
            if (!_context.Equipe.Any())
                _context.Equipe.AddRange(listaEquiepe);

            if (!_context.Cliente.Any())
                _context.Cliente.AddRange(listaCliente);

            if (!_context.FaixaEtaria.Any())
                _context.FaixaEtaria.AddRange(listafaixaEtaria);
            // ////////================================3° Etapa============
            if (!_context.PrecoPlano.Any())
                _context.PrecoPlano.AddRange(listaPrecoPlano);
            // ////////================================4° Etapa============
            if (!_context.Dependente.Any())
                _context.Dependente.AddRange(listaDependente);
            // //////////================================5° Etapa============
             if (!_context.Proposta.Any())
                 _context.Proposta.AddRange(listaProposta);


            _context.SaveChanges();

        }
    }
}
