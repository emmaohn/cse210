using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        List<Video> _videos = new List<Video>();

        // video 1
        Video video1 = new Video("Cardinals in the snow", "Birds of Indiana", 303);
        video1.Comment("George335", "Nice Orioles!");
        video1.Comment("Emmett4evA", "Pretty birbs");
        video1.Comment("EmmaForBirds00", "More hummingbirds?");
        _videos.Add(video1);

        Video video2 = new Video("Some birds but mostly a chipmunk", "Chipmunks of Indiana", 793);
        video2.Comment("LeviW", "Haha, his cheeks so full hehe");
        video2.Comment("EmmaForBirds00", "More Birds pls");
        video2.Comment("Jas0n024", "Oh, yeah! Good stuff");
        _videos.Add(video2);

        Video video3 = new Video("Blue jays in Indiana", "Indiana Blue Jays", 1107);
        video3.Comment("GrantNTruds", "Sweet birds! We love when the geese come to our pond for the winter!");
        video3.Comment("Derek55", "I once saw a bird--great stuff");
        video3.Comment("Russ", "Generally I prefer eagles, but these are some nice birds");
        _videos.Add(video3);

        foreach(Video video in _videos) {
            video.Print();
        }
    }
}