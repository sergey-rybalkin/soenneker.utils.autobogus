﻿using System;
using System.Collections.Generic;

namespace Soenneker.Utils.AutoBogus.Tests.Dtos.Abstract;

public interface IRepository
{
    Item Get(Guid id);

    IEnumerable<Item> GetAll();

    IEnumerable<Item> GetFiltered(Func<Item, bool> filter);
}