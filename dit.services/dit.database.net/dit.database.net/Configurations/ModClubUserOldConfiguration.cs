using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dit.database.net.Configurations;

public class ModClubUserOldConfiguration : IEntityTypeConfiguration<ModClubUserOld>
{
    public void Configure(EntityTypeBuilder<ModClubUserOld> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("mod_club_user_old");

        builder.HasIndex(e => e.Country, "country");

        builder.HasIndex(e => new { e.Id, e.Username }, "id");

        builder.HasIndex(e => e.Username, "username").IsUnique();

        builder.Property(e => e.Id)
            .HasColumnType("int(11) unsigned")
            .HasColumnName("id");
        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Address)
            .HasMaxLength(128)
            .HasColumnName("address");
        builder.Property(e => e.AgreeList)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("agree_list");
        builder.Property(e => e.Blocked).HasColumnName("blocked");
        builder.Property(e => e.BoardFunction)
            .HasMaxLength(255)
            .HasComment("Functie beschrijving")
            .HasColumnName("board_function");
        builder.Property(e => e.BoardMember)
            .HasComment("Bestuurslid")
            .HasColumnName("board_member");
        builder.Property(e => e.BoardType)
            .HasMaxLength(32)
            .HasColumnName("board_type");
        builder.Property(e => e.CanPostOnWall)
            .IsRequired()
            .HasDefaultValueSql("'1'")
            .HasColumnName("can_post_on_wall");
        builder.Property(e => e.City)
            .HasMaxLength(128)
            .HasColumnName("city");
        builder.Property(e => e.Comments)
            .HasColumnType("text")
            .HasColumnName("comments");
        builder.Property(e => e.CommentsIntern)
            .HasColumnType("text")
            .HasColumnName("comments_intern");
        builder.Property(e => e.Country)
            .HasMaxLength(2)
            .HasColumnName("country");
        builder.Property(e => e.DateCreated)
            .HasColumnType("datetime")
            .HasColumnName("date_created");
        builder.Property(e => e.DateModified)
            .HasColumnType("datetime")
            .HasColumnName("date_modified");
        builder.Property(e => e.Dob)
            .HasDefaultValueSql("'''0000-00-00'''")
            .HasColumnType("date")
            .HasColumnName("dob");
        builder.Property(e => e.Email)
            .HasMaxLength(255)
            .HasColumnName("email");
        builder.Property(e => e.EventManagementLevel)
            .HasColumnType("int(1)")
            .HasColumnName("event_management_level");
        builder.Property(e => e.Firstname)
            .HasMaxLength(64)
            .HasColumnName("firstname");
        builder.Property(e => e.Gender)
            .HasColumnType("enum('m','f')")
            .HasColumnName("gender");
        builder.Property(e => e.InfoAvond).HasColumnName("info_avond");
        builder.Property(e => e.Lastname)
            .HasMaxLength(64)
            .HasColumnName("lastname");
        builder.Property(e => e.MailinglistSubId)
            .HasColumnType("int(11)")
            .HasColumnName("mailinglist_sub_id");
        builder.Property(e => e.MemberNumber)
            .HasColumnType("int(11)")
            .HasColumnName("member_number");
        builder.Property(e => e.Referrer)
            .HasMaxLength(255)
            .HasColumnName("referrer");
        builder.Property(e => e.ReferrerExtra)
            .HasMaxLength(255)
            .HasColumnName("referrer_extra");
        builder.Property(e => e.Telephone)
            .HasMaxLength(15)
            .HasComment("Telefoon")
            .HasColumnName("telephone");
        builder.Property(e => e.Telephone2)
            .HasMaxLength(15)
            .HasComment("GSM")
            .HasColumnName("telephone2");
        builder.Property(e => e.Type)
            .HasComment("0: Aspirant, 1: Lid, 2: Oud Lid")
            .HasColumnType("enum('0','1','2')")
            .HasColumnName("type");
        builder.Property(e => e.Username)
            .HasMaxLength(64)
            .HasColumnName("username");
        builder.Property(e => e.Zipcode)
            .HasMaxLength(10)
            .HasColumnName("zipcode");
    }
}
