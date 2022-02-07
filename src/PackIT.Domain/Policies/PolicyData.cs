﻿using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies;

public record PolicyData(TravelDays Days, Consts.Gender Gender, Temperature Temperature,
        Localization Localization);