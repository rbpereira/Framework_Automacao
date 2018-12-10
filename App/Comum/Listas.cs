using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Comum
{
    public static class Listas
    {
        public static Random RandList = new Random();
        public static int index = 0;
        public static string estacaoEscolhida;
        public static string estacao;
        public static string local;
        public static string localEscolhido;
        public static string EnderecoEscolhido;
        public static string endereco;
        public static string Estacoes()
        {
            List<string> Estacoes = new List<string>();
            {
                Estacoes.Add("Metrô Butantã");
                Estacoes.Add("Metrô São Bento");
                Estacoes.Add("Metrô Artur Alvim");
                Estacoes.Add("Metrô Itaquera");
                Estacoes.Add("CPTM Pinheiros");
                Estacoes.Add("CPTM Osasco");
                Estacoes.Add("CPTM Lapa");

                while (estacaoEscolhida == estacao)
                {
                    index = RandList.Next(Estacoes.Count);
                    estacaoEscolhida = Estacoes[index];
                }
                estacao = estacaoEscolhida;
                return estacaoEscolhida;
            }
        }

        public static string Locais()
        {
            List<string> Local = new List<string>();
            {
                Local.Add("Prodesp - Sede");
                Local.Add("Prodesp - Boa Vista");
                Local.Add("Prodesp - SEFAZ");
                Local.Add("Outro");
            }

            while (localEscolhido == local)
            {
                index = RandList.Next(Local.Count);
                localEscolhido = Local[index];
            }

            local = localEscolhido;
            return localEscolhido;
        }

        public static string Pedagios()
        {
            List<string> Pedagio = new List<string>();
            {
                Pedagio.Add("Km 0,3 Raimundo Pereira Magalhães (Interna)");
                Pedagio.Add("Km 3,6 Bandeirantes (Interna)");
                Pedagio.Add("Km 3 Bandeirantes (Externa)");
                Pedagio.Add("Km 7 Anhanguera (Interna Sul)");
                Pedagio.Add("Km 15,6 Castello Branco (Interna)");
                Pedagio.Add("Km 25,3 Regis Bittencourt (Externa)");
                Pedagio.Add("Km 50 Praça 1 – Parelheiros");
                Pedagio.Add("Km 298,8 Itapecerica da Serra");
                Pedagio.Add("Km 205 Arujá(Praça auxiliar saída Rodoanel Leste)");
                Pedagio.Add("Km 180 Guararema Sul");
                Pedagio.Add("Km 268,1 Marília ");
                Pedagio.Add("Km 82 Valinhos Norte");
                Pedagio.Add("Km 215 Pirassununga");
                Pedagio.Add("Km 405 Ituverava");
            }
                index = RandList.Next(Pedagio.Count);

            return Pedagio[index];
        }

        public static string EnderecosDeSp()
        {
            List<string> Endereco = new List<string>();
            {
                Endereco.Add("Avenida Jabaquara - Mirandópolis, São Paulo - SP, Brasil");
                Endereco.Add("Avenida Jacu Pêssego - Vila Jacui, São Paulo - SP, Brasil");
                Endereco.Add("Avenida Pedro Álvares Cabral - Parque Ibirapuera, São Paulo - SP, Brasil");
                Endereco.Add("Avenida 23 de Maio - Vila Mariana, São Paulo - SP, Brasil");
                Endereco.Add("Avenida 23 de Maio - Vila Mariana, São Paulo - SP, Brasil");
                Endereco.Add("Rua Castro Alves - Aclimação, São Paulo - SP, Brasil");
            }

            while (EnderecoEscolhido == endereco)
            {
                index = RandList.Next(Endereco.Count);
                EnderecoEscolhido = Endereco[index];
            }

            endereco = EnderecoEscolhido;
            return EnderecoEscolhido;
        }

        public static string Cursos()
        {
            List<string> Cursos = new List<string>();
            {
                Cursos.Add("Administração de Banco de Dados");
                Cursos.Add("Administração de Redes");
                Cursos.Add("Arquitetura da Informação");
                Cursos.Add("E-Commerce (Comércio Eletrônico)");
                Cursos.Add("Processamento de Dados");
                Cursos.Add("Programação");
                Cursos.Add("Qualidade de Software");
                Cursos.Add("Segurança da Informação");
                Cursos.Add("Suporte Técnico em Informática");
                Cursos.Add("Cloud Computing");
                Cursos.Add("Excel 2013");
                Cursos.Add("Desenvolvimento de Jogos com Unreal");
                Cursos.Add("Introdução à Engenharia de Software");
                Cursos.Add("Tecnologia da Informação");
                Cursos.Add("Bootstrap - design responsivo");
                Cursos.Add("Cordova - aplicativos móveis ");
                Cursos.Add("Desenvolvedor Back-End");
                Cursos.Add("Desenvolvedor Web - UX design");
                Cursos.Add("Desenvolvedor Web - front end");
                Cursos.Add("JavaScript e jQuery");
                Cursos.Add("Administração");
                Cursos.Add("Contabilidade");
                Cursos.Add("Secretáriado");
                Cursos.Add("WordPress - avançado");
                Cursos.Add("Virtualização com Windows Server - Hyper-V");
                Cursos.Add("Virtualização de Infraestrutura com Xen");
                Cursos.Add("Administração do Ubuntu Server");
                Cursos.Add("MS Project 2016 - ferramenta de planejamento e gestão de projetos");
            }
            index = RandList.Next(Cursos.Count);

            return Cursos[index];
        }
    }
}