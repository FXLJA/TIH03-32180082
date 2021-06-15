public class QuizDatabase : QuizDatabaseBase
{
    public static void InitDatabase() {
        Level1();
        Level2();
    }

    static void Level1() {
        CreateTable("tbl_a");
        AddSoal(
            "Struktur Atom H adalah",
            CreatePilihan(
                "1 Proton, 1 Neutron, 1 Elektron",
                "1 Proton, 0 Neutron, 0 Elektron",
                "1 Proton, 1 Neutron, 0 Elektron",
                "1 Proton, 0 Neutron, 1 Elektron"
            ),
            3,
            1
        );
        AddSoal(
            "Struktur Atom C adalah",
            CreatePilihan(
                "6 Proton, 12 Neutron, 6 Elektron",
                "6 Proton, 6 Neutron, 12 Elektron",
                "6 Proton, 6 Neutron, 6 Elektron",
                "12 Proton, 12 Neutron, 12 Elektron"
            ),
            2,
            0
        );
        AddSoal(
            "Struktur Atom O adalah",
            CreatePilihan(
                "8 Proton, 0 Neutron, 8 Elektron",
                "0 Proton, 8 Neutron, 8 Elektron",
                "8 Proton, 8 Neutron, 0 Elektron",
                "8 Proton, 8 Neutron, 8 Elektron"
            ),
            3,
            2
        );
        SaveTable();
    }

    static void Level2() {
        CreateTable("tbl_b");

        AddSoal(
            "Yang BUKAN merupakan kegunaan Hidrogen",
            CreatePilihan(
                "Bomb",
                "Sun",
                "Breathing"
            ),
            2
        );

        AddSoal(
            "Yang merupakan kegunaan Carbon",
            CreatePilihan(
                "Graphite",
                "Bone",
                "Diamond"
            ),
            2
        );

        AddSoal(
            "Yang BUKAN merupakan kegunaan Oksigen",
            CreatePilihan(
                "Hydrant",
                "Breathe",
                "Explosion"
            ),
            0
        );

        SaveTable();
    }

}
