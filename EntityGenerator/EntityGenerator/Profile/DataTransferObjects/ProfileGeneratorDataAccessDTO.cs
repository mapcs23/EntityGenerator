﻿using System;

namespace EntityGenerator.Profile.DataTransferObject
{
  /// <summary>
  /// Class <see cref="ProfileGeneratorDataAccessDto"/> models generator settings for the data access project.
  /// </summary>
  [Serializable]
  public class ProfileGeneratorDataAccessDto
  {
    /// <summary>
    /// Constructor for <see cref="ProfileGeneratorDataAccessDto"/> class.
    /// </summary>
    public ProfileGeneratorDataAccessDto()
    {
    }

    /// <summary>
    /// Flag for generating async data access objects.
    /// </summary>
    public bool AsyncDaos { get; set; }

    /// <summary>
    /// Flag for generating sync data access objects.
    /// </summary>
    public bool SyncDaos { get; set; }

    /// <summary>
    /// Flag for generating data access objects for tables.
    /// </summary>
    public bool Tables { get; set; }

    /// <summary>
    /// Flag for generating data access objects for views.
    /// </summary>
    public bool Views { get; set; }

    /// <summary>
    /// Flag for generating data access objects for parameterized views.
    /// </summary>
    public bool ParameterizedViews { get; set; }

    /// <summary>
    /// Flag for generating data access objects for database functions.
    /// </summary>
    public bool Functions { get; set; }
  }
}
