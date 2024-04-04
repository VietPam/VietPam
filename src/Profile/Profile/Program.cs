using Builder.Models;
using Builder.Models.Enums;

Developer viet = Developer
      .Employed()
      .Musician("🎸", Level.Fine)
      .BornIn(Cities.DaNang, year: 2002)
      .LivesIn(Cities.HoChiMinh, since: 2020)
      .CodesIn(languages => languages
          .CSharp()
          .Dart()
          .Typescript())
      .Interested(@in => @in
          .Backend_DotNet()
          .Mobile_Flutter()
          .Frontend_ReactJS())
      .Found(at => at
          .Portfolio("https://dev-quangviet.click/")
          .LinkedIn("https://www.linkedin.com/in/vietpam/")); ;

while (viet.HasLife)
{
    viet.Code();
    viet.LookForAGirlFriend();
    viet.EnjoyLife();

    Console.WriteLine("Strive to become a CTO");
}

throw new NotImplementedException("UnitTest & Web api & Decorator");