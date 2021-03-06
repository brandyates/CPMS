// <auto-generated />
using System;
using CPMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CPMS.Migrations
{
    [DbContext(typeof(CPMSDbContext))]
    [Migration("20210711235255_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CPMS.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AuthorID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<string>("Affiliation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<string>("Department")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<string>("EmailAddress")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<string>("MiddleInitial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(1)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(1);

                    b.Property<string>("Password")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(5)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(5);

                    b.Property<string>("PhoneNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<string>("State")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(2)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(2);

                    b.Property<string>("ZipCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(10)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(10);

                    b.HasKey("AuthorId");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("CPMS.Models.Defaults", b =>
                {
                    b.Property<bool?>("EnabledAuthors")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("EnabledReviewers")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.ToTable("Defaults");
                });

            modelBuilder.Entity("CPMS.Models.Paper", b =>
                {
                    b.Property<int>("PaperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PaperID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool?>("AnalysisOfAlgorithms")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Applications")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Architecture")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("ArtificialIntelligence")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("AuthorId")
                        .HasColumnName("AuthorID")
                        .HasColumnType("int");

                    b.Property<string>("Certification")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(3)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(3);

                    b.Property<bool?>("ComputerEngineering")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Curriculum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("DataStructures")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Databases")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("DistanceLearning")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("DistributedSystems")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("EthicalSocietalIssues")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Filename")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(100);

                    b.Property<string>("FilenameOriginal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(100);

                    b.Property<bool?>("FirstYearComputing")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("GenderIssues")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("GrantWriting")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("GraphicsImageProcessing")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("HumanComputerInteraction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("LaboratoryEnvironments")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Literacy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("MathematicsInComputing")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Multimedia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("NetworkingDataCommunications")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("NonMajorCourses")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("NotesToReviewers")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("('')");

                    b.Property<bool?>("ObjectOrientedIssues")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("OperatingSystems")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Other")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("OtherDescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<bool?>("ParallelsProcessing")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Pedagogy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("ProgrammingLanguages")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Research")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Security")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("SoftwareEngineering")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("SystemsAnalysisAndDesign")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Title")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(200)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(200);

                    b.Property<bool?>("UsingTechnologyInTheClassroom")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool>("WebAndInternetProgramming")
                        .HasColumnType("bit");

                    b.HasKey("PaperId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Paper");
                });

            modelBuilder.Entity("CPMS.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ReviewID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("AppropriatenessOfTopic")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("CitationOfPreviousWork")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("ClarityOfMainMessage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("ComfortLevelAcceptability")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("ComfortLevelTopic")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Complete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("ContentComments")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("('')");

                    b.Property<decimal?>("Mechanics")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("OrganizationOfPaper")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("Originality")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("OverallRating")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("OverallRatingComments")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("('')");

                    b.Property<int?>("PaperId")
                        .HasColumnName("PaperID")
                        .HasColumnType("int");

                    b.Property<string>("PotentialForOralPresentationComments")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("('')");

                    b.Property<decimal?>("PotentialInterestInTopic")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("ReviewerId")
                        .HasColumnName("ReviewerID")
                        .HasColumnType("int");

                    b.Property<decimal?>("ScopeOfCoverage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("SuitabilityForPresentation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("SupportiveEvidence")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("TechnicalQuality")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("TimelinessOfTopic")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3, 2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("WrittenDocumentComments")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("('')");

                    b.HasKey("ReviewId");

                    b.HasIndex("PaperId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("CPMS.Models.Reviewer", b =>
                {
                    b.Property<int>("ReviewerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ReviewerID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Address")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<string>("Affiliation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<bool?>("AnalysisOfAlgorithms")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Applications")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Architecture")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("ArtificialIntelligence")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("City")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<bool?>("ComputerEngineering")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Curriculum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("DataStructures")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Databases")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Department")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<bool?>("DistancedLearning")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("DistributedSystems")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("EmailAddress")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(100);

                    b.Property<bool?>("EthicalSocietalIssues")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("FirstName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<bool?>("FirstYearComputing")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("GenderIssues")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("GrantWriting")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("GraphicsImageProcessing")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("HumanComputerInteraction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("LaboratoryEnvironments")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("LastName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<bool?>("Literacy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("MathematicsInComputing")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("MiddleInitial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(1)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(1);

                    b.Property<bool?>("Multimedia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("NetworkingDataCommunications")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("NonMajorCourses")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("ObjectOrientedIssues")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("OperatingSystems")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Other")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("OtherDescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<bool?>("ParallelProcessing")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Password")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(5)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(5);

                    b.Property<bool?>("Pedagogy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("PhoneNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<bool?>("ProgrammingLanguages")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Research")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("ReviewsAcknowledged")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Security")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("SoftwareEngineering")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("State")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(2)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(2);

                    b.Property<bool?>("SystemsAnalysisAndDesign")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("UsingTechnologyInTheClassroom")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool>("WebAndInternetProgramming")
                        .HasColumnType("bit");

                    b.Property<string>("ZipCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(10)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(10);

                    b.HasKey("ReviewerId");

                    b.ToTable("Reviewer");
                });

            modelBuilder.Entity("CPMS.Models.Paper", b =>
                {
                    b.HasOne("CPMS.Models.Author", "Author")
                        .WithMany("Paper")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK_Paper_Author");
                });

            modelBuilder.Entity("CPMS.Models.Review", b =>
                {
                    b.HasOne("CPMS.Models.Paper", "Paper")
                        .WithMany("Review")
                        .HasForeignKey("PaperId")
                        .HasConstraintName("FK_Score_Paper")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CPMS.Models.Reviewer", "Reviewer")
                        .WithMany("Review")
                        .HasForeignKey("ReviewerId")
                        .HasConstraintName("FK_Review_Reviewer");
                });
#pragma warning restore 612, 618
        }
    }
}
