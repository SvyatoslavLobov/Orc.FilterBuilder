﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITestDataService.cs" company="Orcomp development team">
//   Copyright (c) 2008 - 2014 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace FilterBuilder.Example.Services
{
    using System;
    using System.Collections.ObjectModel;
    using Models;

    public interface ITestDataService
    {
        ObservableCollection<TestEntity> GetTestItems();
        ObservableCollection<TestEntity> GenerateTestItems();
        TestEntity GenerateRandomEntity();
        DateTime GetRandomDateTime();
        string GetRandomString();
    }
}