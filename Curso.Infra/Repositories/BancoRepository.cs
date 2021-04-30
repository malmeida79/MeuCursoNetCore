﻿using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Entities;
using Curso.Infra.Repositories.Base;
using Curso.Infra.Repositories.Context;
using System.Collections.Generic;
using System.Linq;

namespace Curso.Infra.Repositories
{
    public class BancoRepository : BaseRepository<Banco>, IBancoRepository
    {

        //public BancoRepository(BancosContext dbContext) : base(dbContext)
        //{
            
        //}

        //public BancoRepository() { 
        
        //}

        public Banco GetBancosById(int id)
        {
            var pesquisa = GetBancos().Where(x => x.CodBanco == id).FirstOrDefault();
            return pesquisa;
        }

        public Banco GetBancosByName(string nome)
        {
            var pesquisa = GetBancos().Where(x => x.NomeBanco.Contains(nome)).FirstOrDefault();
            return pesquisa;
        }

        public List<Banco> GetBancos()
        {

            var retorno = new List<Banco>();

            retorno.Add(new Banco { CodBanco = 332, NomeBanco = "Acesso Soluções de Pagamento S.A." });
            retorno.Add(new Banco { CodBanco = 117, NomeBanco = "ADVANCED CORRETORA DE CÂMBIO LTDA" });
            retorno.Add(new Banco { CodBanco = 272, NomeBanco = "AGK CORRETORA DE CAMBIO S.A." });
            retorno.Add(new Banco { CodBanco = 349, NomeBanco = "AMAGGI S.A. - CRÉDITO, FINANCIAMENTO E INVESTIMENTO" });
            retorno.Add(new Banco { CodBanco = 188, NomeBanco = "ATIVA INVESTIMENTOS S.A. CORRETORA DE TÍTULOS, CÂMBIO E VALORES" });
            retorno.Add(new Banco { CodBanco = 280, NomeBanco = "Avista S.A. Crédito, Financiamento e Investimento" });
            retorno.Add(new Banco { CodBanco = 80, NomeBanco = "B&T CORRETORA DE CAMBIO LTDA." });
            retorno.Add(new Banco { CodBanco = 654, NomeBanco = "Banco A.J.Renner S.A." });
            retorno.Add(new Banco { CodBanco = 246, NomeBanco = "Banco ABC Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 75, NomeBanco = "Banco ABN AMRO S.A." });
            retorno.Add(new Banco { CodBanco = 121, NomeBanco = "Banco Agibank S.A." });
            retorno.Add(new Banco { CodBanco = 25, NomeBanco = "Banco Alfa S.A." });
            retorno.Add(new Banco { CodBanco = 65, NomeBanco = "Banco Andbank (Brasil) S.A." });
            retorno.Add(new Banco { CodBanco = 213, NomeBanco = "Banco Arbi S.A." });
            retorno.Add(new Banco { CodBanco = 96, NomeBanco = "Banco B3 S.A." });
            retorno.Add(new Banco { CodBanco = 24, NomeBanco = "Banco BANDEPE S.A." });
            retorno.Add(new Banco { CodBanco = 330, NomeBanco = "Banco Bari de Investimentos e Financiamentos S/A" });
            retorno.Add(new Banco { CodBanco = 318, NomeBanco = "Banco BMG S.A." });
            retorno.Add(new Banco { CodBanco = 752, NomeBanco = "Banco BNP Paribas Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 107, NomeBanco = "Banco BOCOM BBM S.A." });
            retorno.Add(new Banco { CodBanco = 63, NomeBanco = "Banco Bradescard S.A." });
            retorno.Add(new Banco { CodBanco = 36, NomeBanco = "Banco Bradesco BBI S.A." });
            retorno.Add(new Banco { CodBanco = 122, NomeBanco = "Banco Bradesco BERJ S.A." });
            retorno.Add(new Banco { CodBanco = 394, NomeBanco = "Banco Bradesco Financiamentos S.A." });
            retorno.Add(new Banco { CodBanco = 237, NomeBanco = "Banco Bradesco S.A." });
            retorno.Add(new Banco { CodBanco = 218, NomeBanco = "Banco BS2 S.A." });
            retorno.Add(new Banco { CodBanco = 208, NomeBanco = "Banco BTG Pactual S.A." });
            retorno.Add(new Banco { CodBanco = 336, NomeBanco = "Banco C6 S.A." });
            retorno.Add(new Banco { CodBanco = 473, NomeBanco = "Banco Caixa Geral - Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 412, NomeBanco = "Banco Capital S.A." });
            retorno.Add(new Banco { CodBanco = 40, NomeBanco = "Banco Cargill S.A." });
            retorno.Add(new Banco { CodBanco = 739, NomeBanco = "Banco Cetelem S.A." });
            retorno.Add(new Banco { CodBanco = 233, NomeBanco = "Banco Cifra S.A." });
            retorno.Add(new Banco { CodBanco = 745, NomeBanco = "Banco Citibank S.A." });
            retorno.Add(new Banco { CodBanco = 241, NomeBanco = "Banco Clássico S.A." });
            retorno.Add(new Banco { CodBanco = 756, NomeBanco = "Banco Cooperativo do Brasil S.A. - BANCOOB" });
            retorno.Add(new Banco { CodBanco = 748, NomeBanco = "Banco Cooperativo Sicredi S.A." });
            retorno.Add(new Banco { CodBanco = 222, NomeBanco = "Banco Credit Agricole Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 505, NomeBanco = "Banco Credit Suisse (Brasil) S.A." });
            retorno.Add(new Banco { CodBanco = 69, NomeBanco = "Banco Crefisa S.A." });
            retorno.Add(new Banco { CodBanco = 266, NomeBanco = "Banco Cédula S.A." });
            retorno.Add(new Banco { CodBanco = 3, NomeBanco = "Banco da Amazônia S.A." });
            retorno.Add(new Banco { CodBanco = 83, NomeBanco = "Banco da China Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 707, NomeBanco = "Banco Daycoval S.A." });
            retorno.Add(new Banco { CodBanco = 300, NomeBanco = "Banco de La Nacion Argentina" });
            retorno.Add(new Banco { CodBanco = 495, NomeBanco = "Banco de La Provincia de Buenos Aires" });
            retorno.Add(new Banco { CodBanco = 335, NomeBanco = "Banco Digio S.A." });
            retorno.Add(new Banco { CodBanco = 1, NomeBanco = "Banco do Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 47, NomeBanco = "Banco do Estado de Sergipe S.A." });
            retorno.Add(new Banco { CodBanco = 37, NomeBanco = "Banco do Estado do Pará S.A." });
            retorno.Add(new Banco { CodBanco = 41, NomeBanco = "Banco do Estado do Rio Grande do Sul S.A." });
            retorno.Add(new Banco { CodBanco = 4, NomeBanco = "Banco do Nordeste do Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 265, NomeBanco = "Banco Fator S.A." });
            retorno.Add(new Banco { CodBanco = 224, NomeBanco = "Banco Fibra S.A." });
            retorno.Add(new Banco { CodBanco = 626, NomeBanco = "Banco Ficsa S.A." });
            retorno.Add(new Banco { CodBanco = 94, NomeBanco = "Banco Finaxis S.A." });
            retorno.Add(new Banco { CodBanco = 612, NomeBanco = "Banco Guanabara S.A." });
            retorno.Add(new Banco { CodBanco = 12, NomeBanco = "Banco Inbursa S.A." });
            retorno.Add(new Banco { CodBanco = 604, NomeBanco = "Banco Industrial do Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 653, NomeBanco = "Banco Indusval S.A." });
            retorno.Add(new Banco { CodBanco = 77, NomeBanco = "Banco Inter S.A." });
            retorno.Add(new Banco { CodBanco = 249, NomeBanco = "Banco Investcred Unibanco S.A." });
            retorno.Add(new Banco { CodBanco = 479, NomeBanco = "Banco ItauBank S.A" });
            retorno.Add(new Banco { CodBanco = 184, NomeBanco = "Banco Itaú BBA S.A." });
            retorno.Add(new Banco { CodBanco = 29, NomeBanco = "Banco Itaú Consignado S.A." });
            retorno.Add(new Banco { CodBanco = 376, NomeBanco = "Banco J. P. Morgan S.A." });
            retorno.Add(new Banco { CodBanco = 74, NomeBanco = "Banco J. Safra S.A." });
            retorno.Add(new Banco { CodBanco = 217, NomeBanco = "Banco John Deere S.A." });
            retorno.Add(new Banco { CodBanco = 76, NomeBanco = "Banco KDB S.A." });
            retorno.Add(new Banco { CodBanco = 757, NomeBanco = "Banco KEB HANA do Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 600, NomeBanco = "Banco Luso Brasileiro S.A." });
            retorno.Add(new Banco { CodBanco = 389, NomeBanco = "Banco Mercantil do Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 370, NomeBanco = "Banco Mizuho do Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 746, NomeBanco = "Banco Modal S.A." });
            retorno.Add(new Banco { CodBanco = 66, NomeBanco = "Banco Morgan Stanley S.A." });
            retorno.Add(new Banco { CodBanco = 456, NomeBanco = "Banco MUFG Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 243, NomeBanco = "Banco Máxima S.A." });
            retorno.Add(new Banco { CodBanco = 7, NomeBanco = "Banco Nacional de Desenvolvimento Econômico e Social - BNDES" });
            retorno.Add(new Banco { CodBanco = 169, NomeBanco = "Banco Olé Bonsucesso Consignado S.A." });
            retorno.Add(new Banco { CodBanco = 79, NomeBanco = "Banco Original do Agronegócio S.A." });
            retorno.Add(new Banco { CodBanco = 212, NomeBanco = "Banco Original S.A." });
            retorno.Add(new Banco { CodBanco = 712, NomeBanco = "Banco Ourinvest S.A." });
            retorno.Add(new Banco { CodBanco = 623, NomeBanco = "Banco PAN S.A." });
            retorno.Add(new Banco { CodBanco = 611, NomeBanco = "Banco Paulista S.A." });
            retorno.Add(new Banco { CodBanco = 643, NomeBanco = "Banco Pine S.A." });
            retorno.Add(new Banco { CodBanco = 747, NomeBanco = "Banco Rabobank International Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 633, NomeBanco = "Banco Rendimento S.A." });
            retorno.Add(new Banco { CodBanco = 741, NomeBanco = "Banco Ribeirão Preto S.A." });
            retorno.Add(new Banco { CodBanco = 120, NomeBanco = "Banco Rodobens S.A." });
            retorno.Add(new Banco { CodBanco = 422, NomeBanco = "Banco Safra S.A." });
            retorno.Add(new Banco { CodBanco = 33, NomeBanco = "Banco Santander (Brasil) S.A." });
            retorno.Add(new Banco { CodBanco = 743, NomeBanco = "Banco Semear S.A." });
            retorno.Add(new Banco { CodBanco = 754, NomeBanco = "Banco Sistema S.A." });
            retorno.Add(new Banco { CodBanco = 630, NomeBanco = "Banco Smartbank S.A." });
            retorno.Add(new Banco { CodBanco = 366, NomeBanco = "Banco Société Générale Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 637, NomeBanco = "Banco Sofisa S.A." });
            retorno.Add(new Banco { CodBanco = 464, NomeBanco = "Banco Sumitomo Mitsui Brasileiro S.A." });
            retorno.Add(new Banco { CodBanco = 82, NomeBanco = "Banco Topázio S.A." });
            retorno.Add(new Banco { CodBanco = 18, NomeBanco = "Banco Tricury S.A." });
            retorno.Add(new Banco { CodBanco = 634, NomeBanco = "Banco Triângulo S.A." });
            retorno.Add(new Banco { CodBanco = 655, NomeBanco = "Banco Votorantim S.A." });
            retorno.Add(new Banco { CodBanco = 610, NomeBanco = "Banco VR S.A." });
            retorno.Add(new Banco { CodBanco = 119, NomeBanco = "Banco Western Union do Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 124, NomeBanco = "Banco Woori Bank do Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 348, NomeBanco = "Banco XP S.A." });
            retorno.Add(new Banco { CodBanco = 81, NomeBanco = "BancoSeguro S.A." });
            retorno.Add(new Banco { CodBanco = 21, NomeBanco = "BANESTES S.A. Banco do Estado do Espírito Santo" });
            retorno.Add(new Banco { CodBanco = 755, NomeBanco = "Bank of America Merrill Lynch Banco Múltiplo S.A." });
            retorno.Add(new Banco { CodBanco = 268, NomeBanco = "BARI COMPANHIA HIPOTECÁRIA" });
            retorno.Add(new Banco { CodBanco = 250, NomeBanco = "BCV - Banco de Crédito e Varejo S.A." });
            retorno.Add(new Banco { CodBanco = 144, NomeBanco = "BEXS Banco de Câmbio S.A." });
            retorno.Add(new Banco { CodBanco = 253, NomeBanco = "Bexs Corretora de Câmbio S/A" });
            retorno.Add(new Banco { CodBanco = 134, NomeBanco = "BGC LIQUIDEZ DISTRIBUIDORA DE TÍTULOS E VALORES MOBILIÁRIOS LTDA" });
            retorno.Add(new Banco { CodBanco = 17, NomeBanco = "BNY Mellon Banco S.A." });
            retorno.Add(new Banco { CodBanco = 301, NomeBanco = "BPP Instituição de Pagamento S.A." });
            retorno.Add(new Banco { CodBanco = 126, NomeBanco = "BR Partners Banco de Investimento S.A." });
            retorno.Add(new Banco { CodBanco = 70, NomeBanco = "BRB - Banco de Brasília S.A." });
            retorno.Add(new Banco { CodBanco = 92, NomeBanco = "Brickell S.A. Crédito" });
            retorno.Add(new Banco { CodBanco = 173, NomeBanco = "BRL Trust Distribuidora de Títulos e Valores Mobiliários S.A." });
            retorno.Add(new Banco { CodBanco = 142, NomeBanco = "Broker Brasil Corretora de Câmbio Ltda." });
            retorno.Add(new Banco { CodBanco = 292, NomeBanco = "BS2 Distribuidora de Títulos e Valores Mobiliários S.A." });
            retorno.Add(new Banco { CodBanco = 104, NomeBanco = "Caixa Econômica Federal" });
            retorno.Add(new Banco { CodBanco = 309, NomeBanco = "CAMBIONET CORRETORA DE CÂMBIO LTDA." });
            retorno.Add(new Banco { CodBanco = 288, NomeBanco = "CAROL DISTRIBUIDORA DE TITULOS E VALORES MOBILIARIOS LTDA." });
            retorno.Add(new Banco { CodBanco = 130, NomeBanco = "CARUANA S.A. - SOCIEDADE DE CRÉDITO, FINANCIAMENTO E INVESTIMENTO" });
            retorno.Add(new Banco { CodBanco = 159, NomeBanco = "Casa do Crédito S.A. Sociedade de Crédito ao Microempreendedor" });
            retorno.Add(new Banco { CodBanco = 114, NomeBanco = "Central Cooperativa de Crédito no Estado do Espírito Santo - CECOOP" });
            retorno.Add(new Banco { CodBanco = 91, NomeBanco = "CENTRAL DE COOPERATIVAS DE ECONOMIA E CRÉDITO MÚTUO DO ESTADO DO RIO GRANDE DO S" });
            retorno.Add(new Banco { CodBanco = 320, NomeBanco = "China Construction Bank (Brasil) Banco Múltiplo S.A." });
            retorno.Add(new Banco { CodBanco = 477, NomeBanco = "Citibank N.A." });
            retorno.Add(new Banco { CodBanco = 180, NomeBanco = "CM CAPITAL MARKETS CORRETORA DE CÂMBIO, TÍTULOS E VALORES MOBILIÁRIOS LTDA" });
            retorno.Add(new Banco { CodBanco = 127, NomeBanco = "Codepe Corretora de Valores e Câmbio S.A." });
            retorno.Add(new Banco { CodBanco = 163, NomeBanco = "Commerzbank Brasil S.A. - Banco Múltiplo" });
            retorno.Add(new Banco { CodBanco = 133, NomeBanco = "CONFEDERAÇÃO NACIONAL DAS COOPERATIVAS CENTRAIS DE CRÉDITO E ECONOMIA FAMILIAR E" });
            retorno.Add(new Banco { CodBanco = 136, NomeBanco = "CONFEDERAÇÃO NACIONAL DAS COOPERATIVAS CENTRAIS UNICRED LTDA. - UNICRED DO BRASI" });
            retorno.Add(new Banco { CodBanco = 60, NomeBanco = "Confidence Corretora de Câmbio S.A." });
            retorno.Add(new Banco { CodBanco = 85, NomeBanco = "Cooperativa Central de Crédito - AILOS" });
            retorno.Add(new Banco { CodBanco = 97, NomeBanco = "Cooperativa Central de Crédito Noroeste Brasileiro Ltda." });
            retorno.Add(new Banco { CodBanco = 279, NomeBanco = "COOPERATIVA DE CREDITO RURAL DE PRIMAVERA DO LESTE" });
            retorno.Add(new Banco { CodBanco = 16, NomeBanco = "COOPERATIVA DE CRÉDITO MÚTUO DOS DESPACHANTES DE TRÂNSITO DE SANTA CATARINA E RI" });
            retorno.Add(new Banco { CodBanco = 281, NomeBanco = "Cooperativa de Crédito Rural Coopavel" });
            retorno.Add(new Banco { CodBanco = 322, NomeBanco = "Cooperativa de Crédito Rural de Abelardo Luz - Sulcredi/Crediluz" });
            retorno.Add(new Banco { CodBanco = 286, NomeBanco = "COOPERATIVA DE CRÉDITO RURAL DE OURO SULCREDI/OURO" });
            retorno.Add(new Banco { CodBanco = 273, NomeBanco = "Cooperativa de Crédito Rural de São Miguel do Oeste - Sulcredi/São Miguel" });
            retorno.Add(new Banco { CodBanco = 98, NomeBanco = "Credialiança Cooperativa de Crédito Rural" });
            retorno.Add(new Banco { CodBanco = 10, NomeBanco = "CREDICOAMO CREDITO RURAL COOPERATIVA" });
            retorno.Add(new Banco { CodBanco = 89, NomeBanco = "CREDISAN COOPERATIVA DE CRÉDITO" });
            retorno.Add(new Banco { CodBanco = 11, NomeBanco = "CREDIT SUISSE HEDGING-GRIFFO CORRETORA DE VALORES S.A" });
            retorno.Add(new Banco { CodBanco = 342, NomeBanco = "Creditas Sociedade de Crédito Direto S.A." });
            retorno.Add(new Banco { CodBanco = 321, NomeBanco = "CREFAZ SOCIEDADE DE CRÉDITO AO MICROEMPREENDEDOR E A EMPRESA DE PEQUENO PORTE LT" });
            retorno.Add(new Banco { CodBanco = 289, NomeBanco = "DECYSEO CORRETORA DE CAMBIO LTDA." });
            retorno.Add(new Banco { CodBanco = 487, NomeBanco = "Deutsche Bank S.A. - Banco Alemão" });
            retorno.Add(new Banco { CodBanco = 140, NomeBanco = "Easynvest - Título Corretora de Valores SA" });
            retorno.Add(new Banco { CodBanco = 149, NomeBanco = "Facta Financeira S.A. - Crédito Financiamento e Investimento" });
            retorno.Add(new Banco { CodBanco = 196, NomeBanco = "FAIR CORRETORA DE CAMBIO S.A." });
            retorno.Add(new Banco { CodBanco = 343, NomeBanco = "FFA SOCIEDADE DE CRÉDITO AO MICROEMPREENDEDOR E À EMPRESA DE PEQUENO PORTE LTDA." });
            retorno.Add(new Banco { CodBanco = 331, NomeBanco = "Fram Capital Distribuidora de Títulos e Valores Mobiliários S.A." });
            retorno.Add(new Banco { CodBanco = 285, NomeBanco = "Frente Corretora de Câmbio Ltda." });
            retorno.Add(new Banco { CodBanco = 278, NomeBanco = "Genial Investimentos Corretora de Valores Mobiliários S.A." });
            retorno.Add(new Banco { CodBanco = 364, NomeBanco = "GERENCIANET PAGAMENTOS DO BRASIL LTDA" });
            retorno.Add(new Banco { CodBanco = 138, NomeBanco = "Get Money Corretora de Câmbio S.A." });
            retorno.Add(new Banco { CodBanco = 64, NomeBanco = "Goldman Sachs do Brasil Banco Múltiplo S.A." });
            retorno.Add(new Banco { CodBanco = 177, NomeBanco = "Guide Investimentos S.A. Corretora de Valores" });
            retorno.Add(new Banco { CodBanco = 146, NomeBanco = "GUITTA CORRETORA DE CAMBIO LTDA." });
            retorno.Add(new Banco { CodBanco = 78, NomeBanco = "Haitong Banco de Investimento do Brasil S.A." });
            retorno.Add(new Banco { CodBanco = 62, NomeBanco = "Hipercard Banco Múltiplo S.A." });
            retorno.Add(new Banco { CodBanco = 189, NomeBanco = "HS FINANCEIRA S/A CREDITO, FINANCIAMENTO E INVESTIMENTOS" });
            retorno.Add(new Banco { CodBanco = 269, NomeBanco = "HSBC Brasil S.A. - Banco de Investimento" });
            retorno.Add(new Banco { CodBanco = 271, NomeBanco = "IB Corretora de Câmbio, Títulos e Valores Mobiliários S.A." });
            retorno.Add(new Banco { CodBanco = 157, NomeBanco = "ICAP do Brasil Corretora de Títulos e Valores Mobiliários Ltda." });
            retorno.Add(new Banco { CodBanco = 132, NomeBanco = "ICBC do Brasil Banco Múltiplo S.A." });
            retorno.Add(new Banco { CodBanco = 492, NomeBanco = "ING Bank N.V." });
            retorno.Add(new Banco { CodBanco = 139, NomeBanco = "Intesa Sanpaolo Brasil S.A. - Banco Múltiplo" });
            retorno.Add(new Banco { CodBanco = 652, NomeBanco = "Itaú Unibanco Holding S.A." });
            retorno.Add(new Banco { CodBanco = 341, NomeBanco = "Itaú Unibanco S.A." });
            retorno.Add(new Banco { CodBanco = 488, NomeBanco = "JPMorgan Chase Bank" });
            retorno.Add(new Banco { CodBanco = 399, NomeBanco = "Kirton Bank S.A. - Banco Múltiplo" });
            retorno.Add(new Banco { CodBanco = 293, NomeBanco = "Lastro RDV Distribuidora de Títulos e Valores Mobiliários Ltda." });
            retorno.Add(new Banco { CodBanco = 105, NomeBanco = "Lecca Crédito, Financiamento e Investimento S/A" });
            retorno.Add(new Banco { CodBanco = 145, NomeBanco = "LEVYCAM - CORRETORA DE CAMBIO E VALORES LTDA." });
            retorno.Add(new Banco { CodBanco = 113, NomeBanco = "Magliano S.A. Corretora de Cambio e Valores Mobiliarios" });
            retorno.Add(new Banco { CodBanco = 323, NomeBanco = "MERCADOPAGO.COM REPRESENTACOES LTDA." });
            retorno.Add(new Banco { CodBanco = 274, NomeBanco = "MONEY PLUS SOCIEDADE DE CRÉDITO AO MICROEMPREENDEDOR E A EMPRESA DE PEQUENO PORT" });
            retorno.Add(new Banco { CodBanco = 259, NomeBanco = "MONEYCORP BANCO DE CÂMBIO S.A." });
            retorno.Add(new Banco { CodBanco = 128, NomeBanco = "MS Bank S.A. Banco de Câmbio" });
            retorno.Add(new Banco { CodBanco = 354, NomeBanco = "NECTON INVESTIMENTOS S.A. CORRETORA DE VALORES MOBILIÁRIOS E COMMODITIES" });
            retorno.Add(new Banco { CodBanco = 191, NomeBanco = "Nova Futura Corretora de Títulos e Valores Mobiliários Ltda." });
            retorno.Add(new Banco { CodBanco = 753, NomeBanco = "Novo Banco Continental S.A. - Banco Múltiplo" });
            retorno.Add(new Banco { CodBanco = 260, NomeBanco = "Nu Pagamentos S.A." });
            retorno.Add(new Banco { CodBanco = 111, NomeBanco = "OLIVEIRA TRUST DISTRIBUIDORA DE TÍTULOS E VALORES MOBILIARIOS S.A." });
            retorno.Add(new Banco { CodBanco = 319, NomeBanco = "OM DISTRIBUIDORA DE TÍTULOS E VALORES MOBILIÁRIOS LTDA" });
            retorno.Add(new Banco { CodBanco = 613, NomeBanco = "Omni Banco S.A." });
            retorno.Add(new Banco { CodBanco = 290, NomeBanco = "Pagseguro Internet S.A." });
            retorno.Add(new Banco { CodBanco = 254, NomeBanco = "Paraná Banco S.A." });
            retorno.Add(new Banco { CodBanco = 326, NomeBanco = "PARATI - CREDITO, FINANCIAMENTO E INVESTIMENTO S.A." });
            retorno.Add(new Banco { CodBanco = 194, NomeBanco = "PARMETAL DISTRIBUIDORA DE TÍTULOS E VALORES MOBILIÁRIOS LTDA" });
            retorno.Add(new Banco { CodBanco = 174, NomeBanco = "PERNAMBUCANAS FINANCIADORA S.A. - CRÉDITO, FINANCIAMENTO E INVESTIMENTO" });
            retorno.Add(new Banco { CodBanco = 315, NomeBanco = "PI Distribuidora de Títulos e Valores Mobiliários S.A." });
            retorno.Add(new Banco { CodBanco = 100, NomeBanco = "Planner Corretora de Valores S.A." });
            retorno.Add(new Banco { CodBanco = 125, NomeBanco = "Plural S.A. - Banco Múltiplo" });
            retorno.Add(new Banco { CodBanco = 108, NomeBanco = "PORTOCRED S.A. - CREDITO, FINANCIAMENTO E INVESTIMENTO" });
            retorno.Add(new Banco { CodBanco = 306, NomeBanco = "PORTOPAR DISTRIBUIDORA DE TITULOS E VALORES MOBILIARIOS LTDA." });
            retorno.Add(new Banco { CodBanco = 93, NomeBanco = "PÓLOCRED SOCIEDADE DE CRÉDITO AO MICROEMPREENDEDOR E À EMPRESA DE PEQUENO PORT" });
            retorno.Add(new Banco { CodBanco = 329, NomeBanco = "QI Sociedade de Crédito Direto S.A." });
            retorno.Add(new Banco { CodBanco = 283, NomeBanco = "RB CAPITAL INVESTIMENTOS DISTRIBUIDORA DE TÍTULOS E VALORES MOBILIÁRIOS LIMITADA" });
            retorno.Add(new Banco { CodBanco = 101, NomeBanco = "RENASCENCA DISTRIBUIDORA DE TÍTULOS E VALORES MOBILIÁRIOS LTDA" });
            retorno.Add(new Banco { CodBanco = 270, NomeBanco = "Sagitur Corretora de Câmbio Ltda." });
            retorno.Add(new Banco { CodBanco = 751, NomeBanco = "Scotiabank Brasil S.A. Banco Múltiplo" });
            retorno.Add(new Banco { CodBanco = 276, NomeBanco = "Senff S.A. - Crédito, Financiamento e Investimento" });
            retorno.Add(new Banco { CodBanco = 545, NomeBanco = "SENSO CORRETORA DE CAMBIO E VALORES MOBILIARIOS S.A" });
            retorno.Add(new Banco { CodBanco = 190, NomeBanco = "SERVICOOP - COOPERATIVA DE CRÉDITO DOS SERVIDORES PÚBLICOS ESTADUAIS DO RIO GRAN" });
            retorno.Add(new Banco { CodBanco = 183, NomeBanco = "SOCRED S.A. - SOCIEDADE DE CRÉDITO AO MICROEMPREENDEDOR E À EMPRESA DE PEQUENO P" });
            retorno.Add(new Banco { CodBanco = 365, NomeBanco = "SOLIDUS S.A. CORRETORA DE CAMBIO E VALORES MOBILIARIOS" });
            retorno.Add(new Banco { CodBanco = 299, NomeBanco = "SOROCRED CRÉDITO, FINANCIAMENTO E INVESTIMENTO S.A." });
            retorno.Add(new Banco { CodBanco = 14, NomeBanco = "State Street Brasil S.A. - Banco Comercial" });
            retorno.Add(new Banco { CodBanco = 197, NomeBanco = "Stone Pagamentos S.A." });
            retorno.Add(new Banco { CodBanco = 340, NomeBanco = "Super Pagamentos e Administração de Meios Eletrônicos S.A." });
            retorno.Add(new Banco { CodBanco = 307, NomeBanco = "Terra Investimentos Distribuidora de Títulos e Valores Mobiliários Ltda." });
            retorno.Add(new Banco { CodBanco = 352, NomeBanco = "TORO CORRETORA DE TÍTULOS E VALORES MOBILIÁRIOS LTDA" });
            retorno.Add(new Banco { CodBanco = 95, NomeBanco = "Travelex Banco de Câmbio S.A." });
            retorno.Add(new Banco { CodBanco = 143, NomeBanco = "Treviso Corretora de Câmbio S.A." });
            retorno.Add(new Banco { CodBanco = 131, NomeBanco = "TULLETT PREBON BRASIL CORRETORA DE VALORES E CÂMBIO LTDA" });
            retorno.Add(new Banco { CodBanco = 129, NomeBanco = "UBS Brasil Banco de Investimento S.A." });
            retorno.Add(new Banco { CodBanco = 15, NomeBanco = "UBS Brasil Corretora de Câmbio, Títulos e Valores Mobiliários S.A." });
            retorno.Add(new Banco { CodBanco = 99, NomeBanco = "UNIPRIME CENTRAL - CENTRAL INTERESTADUAL DE COOPERATIVAS DE CREDITO LTDA." });
            retorno.Add(new Banco { CodBanco = 84, NomeBanco = "Uniprime Norte do Paraná - Coop de Economia e Crédito Mútuo dos Médicos" });
            retorno.Add(new Banco { CodBanco = 373, NomeBanco = "UP.P SOCIEDADE DE EMPRÉSTIMO ENTRE PESSOAS S.A." });
            retorno.Add(new Banco { CodBanco = 298, NomeBanco = "Vip's Corretora de Câmbio Ltda." });
            retorno.Add(new Banco { CodBanco = 296, NomeBanco = "VISION S.A. CORRETORA DE CAMBIO" });
            retorno.Add(new Banco { CodBanco = 367, NomeBanco = "VITREO DISTRIBUIDORA DE TÍTULOS E VALORES MOBILIÁRIOS S.A." });
            retorno.Add(new Banco { CodBanco = 310, NomeBanco = "VORTX DISTRIBUIDORA DE TITULOS E VALORES MOBILIARIOS LTDA." });
            retorno.Add(new Banco { CodBanco = 102, NomeBanco = "XP INVESTIMENTOS CORRETORA DE CÂMBIO,TÍTULOS E VALORES MOBILIÁRIOS S/A" });
            retorno.Add(new Banco { CodBanco = 325, NomeBanco = "Órama Distribuidora de Títulos e Valores Mobiliários S.A." });
            retorno.Add(new Banco { CodBanco = 355, NomeBanco = "ÓTIMO SOCIEDADE DE CRÉDITO DIRETO S.A." });

            return retorno;
        }

    }
}
