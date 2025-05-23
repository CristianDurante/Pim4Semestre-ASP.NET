﻿// <auto-generated />
using System;
using FazendaUniao.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FazendaUniao.Migrations
{
    [DbContext(typeof(FazendaUniaoContext))]
    [Migration("20241104050821_InicialImigration")]
    partial class InicialImigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("FazendaUniao.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CnpjCliente")
                        .HasMaxLength(18)
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailCliente")
                        .HasColumnType("TEXT");

                    b.Property<string>("EnderecoCliente")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeCliente")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefoneCliente")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("FazendaUniao.Models.EstoqueInsumos", b =>
                {
                    b.Property<int>("EstoqueInsumosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InsumoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("QuantidadeEmEstoque")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("EstoqueInsumosId");

                    b.HasIndex("InsumoId");

                    b.ToTable("EstoqueInsumos");
                });

            modelBuilder.Entity("FazendaUniao.Models.EstoqueProdutos", b =>
                {
                    b.Property<int>("EstoqueProdutosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("QuantidadeEmEstoque")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("EstoqueProdutosId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("EstoqueProdutos");
                });

            modelBuilder.Entity("FazendaUniao.Models.Fornecedores", b =>
                {
                    b.Property<int>("FornecedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("FornecedorId");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("FazendaUniao.Models.Insumo", b =>
                {
                    b.Property<int>("InsumoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int?>("Quantidade")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("InsumoId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Insumo");
                });

            modelBuilder.Entity("FazendaUniao.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClienteId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataPedido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("EstoqueProdutosId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProdutoId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Quantidade")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<double?>("ValorTotal")
                        .HasColumnType("REAL");

                    b.HasKey("PedidoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EstoqueProdutosId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("FazendaUniao.Models.Plantacao", b =>
                {
                    b.Property<int>("PlantacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataColheita")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataPlantio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<int>("InsumoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuantidadePlantio")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoPlanta")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("PlantacaoId");

                    b.HasIndex("InsumoId");

                    b.ToTable("Plantacao");
                });

            modelBuilder.Entity("FazendaUniao.Models.Produtos", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categoria")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<double?>("PrecoUnitario")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("FazendaUniao.Models.EstoqueInsumos", b =>
                {
                    b.HasOne("FazendaUniao.Models.Insumo", "Insumo")
                        .WithMany()
                        .HasForeignKey("InsumoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Insumo");
                });

            modelBuilder.Entity("FazendaUniao.Models.EstoqueProdutos", b =>
                {
                    b.HasOne("FazendaUniao.Models.Produtos", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("FazendaUniao.Models.Insumo", b =>
                {
                    b.HasOne("FazendaUniao.Models.Fornecedores", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("FazendaUniao.Models.Pedido", b =>
                {
                    b.HasOne("FazendaUniao.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FazendaUniao.Models.EstoqueProdutos", "Estoque")
                        .WithMany()
                        .HasForeignKey("EstoqueProdutosId");

                    b.HasOne("FazendaUniao.Models.Produtos", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Estoque");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("FazendaUniao.Models.Plantacao", b =>
                {
                    b.HasOne("FazendaUniao.Models.Insumo", "Insumo")
                        .WithMany()
                        .HasForeignKey("InsumoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Insumo");
                });
#pragma warning restore 612, 618
        }
    }
}
