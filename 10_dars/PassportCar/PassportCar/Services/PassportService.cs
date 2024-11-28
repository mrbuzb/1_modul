using PersonPasport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPasport.Services;

public class PassportService
{
    private List<Passport> passports;


    public PassportService()
    {
        passports = new List<Passport>();
    }

    public Passport AddPassport(Passport passport)
    {
        passport.Id = Guid.NewGuid();
        passports.Add(passport);

        return passport;
    }


    public Passport GetPassportById(Guid id)
    {
        foreach (Passport passport in passports)
        {
            if (id == passport.Id)
            {
                return passport;
            }
        }
        return null;
    }

    public Passport GetPassportByPersonId(Guid personId)
    {
        foreach (Passport passport in passports)
        {
            if (passport.PersonID == personId)
            {
                return passport;
            }
        }
        return null;
    }

    public bool DeletePassport(Guid id)
    {
        var res = GetPassportById(id);

        if (res is null)
        {
            return false;
        }

        passports.Remove(res);
        return true;
    }


    public bool UpdatePassport(Passport passport)
    {
        var res = GetPassportById(passport.Id);

        if (res is null)
        {
            return false;
        }
        passports[passports.IndexOf(res)] = passport;
        return true;
    }


    public List<Passport> GetPassports()
    {
        return passports;
    }

}
