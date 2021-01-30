﻿using System.ComponentModel.DataAnnotations;
using System;
using CsgoEssentials.Domain.Enum;
using System.ComponentModel;
using CsgoEssentials.Infra.Utils;
using System.Collections.Generic;

namespace CsgoEssentials.Domain.Entities
{
    public class Video : IValidatableObject
    {
        #region Constructor

        public Video(string title, DateTime releaseDate, EGrenadeType grenadeType, ETick tickRate,  string description, int userId, int mapId)
        {
            Title = title;
            ReleaseDate = releaseDate;
            GrenadeType = grenadeType;
            TickRate = tickRate;
            Description = description;
            UserId = userId;
            MapId = mapId;
        }

        #endregion

        #region Properties
        [Key]
        public int Id { get; set; }

        [DisplayName(Messages.TITULO)]
        [Required(ErrorMessage = Messages.CAMPO_OBRIGATORIO)]
        [StringLength(maximumLength: 60, ErrorMessage = Messages.CAMPO_PRECISA_TER_ENTRE_X2_E_Y1_CARACTERES, MinimumLength = 4)]
        public string Title { get; set; }

        [DisplayName(Messages.DATA_DE_PUBLICACAO)]
        [Required(ErrorMessage = Messages.CAMPO_OBRIGATORIO)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [DisplayName(Messages.TIPO_DE_GRANADA)]
        [Required(ErrorMessage = Messages.CAMPO_OBRIGATORIO)]
        public EGrenadeType GrenadeType { get; set; }

        [Required(ErrorMessage = Messages.CAMPO_OBRIGATORIO)]
        public ETick TickRate { get; set; }

        [DisplayName(Messages.DESCRICAO)]
        [Required(ErrorMessage = Messages.CAMPO_OBRIGATORIO)]
        [StringLength(maximumLength: 60, ErrorMessage = Messages.CAMPO_PRECISA_TER_ENTRE_X2_E_Y1_CARACTERES, MinimumLength = 3)]
        public string Description { get; set; }

        [Required(ErrorMessage = Messages.CAMPO_OBRIGATORIO)]
        [DisplayName(Messages.USUARIO)]
        public int UserId { get; set; }

        [Required(ErrorMessage = Messages.CAMPO_OBRIGATORIO)]
        [DisplayName(Messages.MAPA)]
        public int MapId { get; set; }

        #endregion

        #region Methods
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            // Validations

            return results;
        }
        #endregion
    }
}
