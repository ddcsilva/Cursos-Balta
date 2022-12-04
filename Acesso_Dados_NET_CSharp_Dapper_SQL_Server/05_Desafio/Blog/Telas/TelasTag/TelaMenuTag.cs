using System;

namespace Blog.Telas.TelasTag
{
    public static class TelaMenuTag
    {
        public static void Carregar()
        {
            {
                Console.Clear();
                Console.WriteLine("Gestão de tags");
                Console.WriteLine("--------------");
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine();
                Console.WriteLine("1 - Listar tags");
                Console.WriteLine("2 - Cadastrar tags");
                Console.WriteLine("3 - Atualizar tag");
                Console.WriteLine("4 - Excluir tag");
                Console.WriteLine();
                Console.WriteLine();

                var opcao = short.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        TelaListTag.Carregar();
                        break;
                    case 2:
                        TelaCreateTag.Carregar();
                        break;
                    case 3:
                        TelaUpdateTag.Carregar();
                        break;
                    case 4:
                        TelaDeleteTag.Carregar();
                        break;
                    default:
                        Carregar();
                        break;
                }
            }
        }
    }
}