SELECT Pet.Name, PetType.PetTypeName FROM PetType
Join Pet ON Pet.TypeId = PetType.Id
WHERE PetType-PetTypeName LIKE 'dog'