db.createUser(
    {
        user: "testdb",
        pwd: "testdb",
        roles: [
            {
                role: "root",
                db: "admin"
            }
        ]
    }
);