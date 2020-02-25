﻿// <auto-generated />
using System;
using ClubestApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClubestApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200225153601_addnewfield")]
    partial class addnewfield
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClubestApp.Data.Models.Club", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<decimal>("Fee");

                    b.Property<string>("Interests");

                    b.Property<bool>("IsPublic");

                    b.Property<string>("Name");

                    b.Property<string>("PictureUrl");

                    b.Property<int>("PriceType");

                    b.Property<string>("Town");

                    b.HasKey("Id");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.ClubAdmin", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("ClubId");

                    b.HasKey("UserId", "ClubId");

                    b.HasIndex("ClubId");

                    b.ToTable("ClubAdmins");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.Comment", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("Date");

                    b.Property<string>("PostId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.Event", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdminId");

                    b.Property<string>("ClubId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Interests");

                    b.Property<bool>("IsPublic");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("ClubId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.EventUser", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("EventId");

                    b.HasKey("UserId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("EventUsers");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.JoinClubRequest", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClubId");

                    b.Property<int>("RequestType");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("UserId");

                    b.ToTable("JoinClubRequests");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.Notification", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<bool>("IsRead");

                    b.Property<string>("Link");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.Option", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<string>("PollId");

                    b.Property<int>("VotesCount");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.Poll", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClubId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("ExpiredDate");

                    b.Property<string>("Interests");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsMultichoice");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Polls");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.PollUser", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("PollId");

                    b.HasKey("UserId", "PollId");

                    b.HasIndex("PollId");

                    b.ToTable("PollUser");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.PollVotedUsers", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("PollId");

                    b.HasKey("UserId", "PollId");

                    b.HasIndex("PollId");

                    b.ToTable("PollVotedUsers");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.Post", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorId");

                    b.Property<string>("ClubId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("FileUrlOrLink");

                    b.Property<int>("PostType");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ClubId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.RequestNewClub", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorId");

                    b.Property<string>("Description");

                    b.Property<decimal>("Fee");

                    b.Property<string>("Interests");

                    b.Property<bool>("IsPublic");

                    b.Property<string>("Name");

                    b.Property<string>("PictureUrl");

                    b.Property<string>("Town");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("RequestNewClubs");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("Interests");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PictureUrl");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Town");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.UserClub", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("ClubId");

                    b.HasKey("UserId", "ClubId");

                    b.HasIndex("ClubId");

                    b.ToTable("UserClubs");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.UserCommentDislikes", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("CommentId");

                    b.HasKey("UserId", "CommentId");

                    b.HasIndex("CommentId");

                    b.ToTable("UserCommentDislikes");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.UserCommentLikes", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("CommentId");

                    b.HasKey("UserId", "CommentId");

                    b.HasIndex("CommentId");

                    b.ToTable("UserCommentLikes");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.UserPostDislikes", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("PostId");

                    b.HasKey("UserId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("UserPostDislikes");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.UserPostLikes", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("PostId");

                    b.HasKey("UserId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("UserPostLikes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.ClubAdmin", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.Club", "Club")
                        .WithMany("ClubAdmins")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClubestApp.Data.Models.User", "User")
                        .WithMany("AdminClubs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClubestApp.Data.Models.Comment", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("ClubestApp.Data.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.Event", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.User", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId");

                    b.HasOne("ClubestApp.Data.Models.Club", "Club")
                        .WithMany("Events")
                        .HasForeignKey("ClubId");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.EventUser", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.Event", "Event")
                        .WithMany("EventUsers")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClubestApp.Data.Models.User", "User")
                        .WithMany("UserEvents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClubestApp.Data.Models.JoinClubRequest", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.Club", "Club")
                        .WithMany("JoinClubRequests")
                        .HasForeignKey("ClubId");

                    b.HasOne("ClubestApp.Data.Models.User", "User")
                        .WithMany("JoinClubRequests")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.Notification", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.Option", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.Poll", "Poll")
                        .WithMany("Options")
                        .HasForeignKey("PollId");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.Poll", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.Club", "Club")
                        .WithMany("Polls")
                        .HasForeignKey("ClubId");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.PollUser", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.Poll", "Poll")
                        .WithMany("PollUsers")
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClubestApp.Data.Models.User", "User")
                        .WithMany("UserPolls")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClubestApp.Data.Models.PollVotedUsers", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.Poll", "Poll")
                        .WithMany("PollVotedUsers")
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClubestApp.Data.Models.User", "User")
                        .WithMany("UserVotedPolls")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClubestApp.Data.Models.Post", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.User", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId");

                    b.HasOne("ClubestApp.Data.Models.Club", "Club")
                        .WithMany("Posts")
                        .HasForeignKey("ClubId");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.RequestNewClub", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.User", "Author")
                        .WithMany("RequestNewClubs")
                        .HasForeignKey("AuthorId");
                });

            modelBuilder.Entity("ClubestApp.Data.Models.UserClub", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.Club", "Club")
                        .WithMany("ClubUsers")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClubestApp.Data.Models.User", "User")
                        .WithMany("UserClubs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClubestApp.Data.Models.UserCommentDislikes", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.Comment", "Comment")
                        .WithMany("UserCommentDislikes")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClubestApp.Data.Models.User", "User")
                        .WithMany("UserCommentDislikes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClubestApp.Data.Models.UserCommentLikes", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.Comment", "Comment")
                        .WithMany("UserCommentLikes")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClubestApp.Data.Models.User", "User")
                        .WithMany("UserCommentLikes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClubestApp.Data.Models.UserPostDislikes", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.Post", "Post")
                        .WithMany("UserPostDislikes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClubestApp.Data.Models.User", "User")
                        .WithMany("UserPostDislikes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClubestApp.Data.Models.UserPostLikes", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.Post", "Post")
                        .WithMany("UserPostLikes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClubestApp.Data.Models.User", "User")
                        .WithMany("UserPostLikes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClubestApp.Data.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ClubestApp.Data.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
