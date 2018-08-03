using System;

public class Member
{
    private int icNo;
    public int IcNo
    {
        get { return icNo; }
        set
        {
            icNo = value;
        }
    }

    private string libraryNo;
    public string LibraryNo
    {
        get { return libraryNo; }
        set
        {
            libraryNo = value;
        }
    }

    private string memberType;
    public string MemberType
    {
        get { return memberType; }
        set
        {
           memberType = value;
        }
    }

    private int dateofBirth;
    public int DateOfBirth
    {
        get { return dateofBirth; }
        set
        {
            dateofBirth = value;
        }
    }

    private int telNo;
    public int TelNo
    {
        get { return telNo; }
        set
        {
            telNo = value;
        }
    }

    private string address;
    public string Address
    {
        get { return address; }
        set
        {
            address = value;
        }
    }

    private string state;
    public string State
    {
        get { return state; }
        set
        {
            state = value;
        }
    }

    private int postcode;
    public int Postcode
    {
        get { return postcode; }
        set
        {
            postcode = value;
        }
    }

    private string country;
    public string Country
    {
        get { return country; }
        set
        {
           country = value;
        }
    }

    public Member(int theIc, string theLibrary, string theType, int theDOB, int theTel, string theAddress, string theState, int thePostCode, string theCountry)
    {
        icNo = theIc;
        libraryNo = theLibrary;
        memberType = theType;
        dateofBirth = theDOB;
        telNo = theTel;
        address = theAddress;
        state = theState;
        postcode = thePostCode;
        country = theCountry;
    }


}
