


```
❯ docker network inspect docker-mariadb-aspnet80_default
[
    {
        "Name": "docker-mariadb-aspnet80_default",
        "Id": "8d9eb4597a2fdf151a1b1ac3bc372e239497b983da682023339bfb755893d5fe",
        "Created": "2024-06-23T20:07:15.112369222+09:00",
        "Scope": "local",
        "Driver": "bridge",
        "EnableIPv6": false,
        "IPAM": {
            "Driver": "default",
            "Options": null,
            "Config": [
                {
                    "Subnet": "172.29.0.0/16",
                    "Gateway": "172.29.0.1"
                }
            ]
        },
        "Internal": false,
        "Attachable": false,
        "Ingress": false,
        "ConfigFrom": {
            "Network": ""
        },
        "ConfigOnly": false,
        "Containers": {
            "1e9e82fde338306f7332e06886f91f76f4a5feb88fddb70e2576a5dc8a5bfe9f": {
                "Name": "docker-mariadb-aspnet80-mysql-1",
                "EndpointID": "723aceffe96400516a2cb4b9a4dadfe1e016d50ab494d49a41b44860f1c56470",
                "MacAddress": "02:42:ac:1d:00:02",
                "IPv4Address": "172.29.0.2/16",
                "IPv6Address": ""
            },
            "34957a7583e377d36a3b2d7a0ffcd751d9511c04f4f52b78b18d73ffcdd4f91c": {
                "Name": "docker-mariadb-aspnet80-adminer-1",
                "EndpointID": "cc203d92e25037ba65776f2460df8b4ecb1133ae30f25d38de7beaa0611c9337",
                "MacAddress": "02:42:ac:1d:00:03",
                "IPv4Address": "172.29.0.3/16",
                "IPv6Address": ""
            }
        },
        "Options": {},
        "Labels": {
            "com.docker.compose.network": "default",
            "com.docker.compose.project": "docker-mariadb-aspnet80",
            "com.docker.compose.version": "2.27.1"
        }
    }
]
```

`docker-mariadb-aspnet80-mysql-1`コンテナのIPに対してAdminerを使用し、ログインできるか確認
```
http://localhost:8080/

# 例
# http://localhost:8080/?server=172.29.0.2&username=xiaobff&db=xiaobff
```


|コマンド|概要|
|-- | --|
|docker network ls |ネットーワークの一覧|
|docker network inspect {ネットーワークの名}|ネットーワークの詳細 |
|docker-compose exec {サービス名} env| コンテナの環境変数取得 |



# 勘どころ(困った時に)

### ネットワーク設定

#### MariaDBの設定確認:
コンテナ内で以下のコマンドを実行し、bind-address の設定を確認
Docker外部からアクセスするために、`bind-address = 0.0.0.0` となっていることを確認

```
docker exec -it docker-mariadb-aspnet80-mysql-1 grep bind-address /etc/mysql/mariadb.conf.d/50-server.cnf
```

#### 編集する場合

置換と目視での確認

コンテナにアクセス
```
docker exec -it docker-mariadb-aspnet80-mysql-1 bash
```

コンテナ内部で実施
```
# 置換
root@3665afbd591f:/# sed -i 's/^#bind-address.*$/bind-address = 0.0.0.0/' /etc/mysql/mariadb.conf.d/50-server.cnf
# 確認
root@3665afbd591f:/# cat /etc/mysql/mariadb.conf.d/50-server.cnf
# 確認
root@3665afbd591f:/# grep bind-address /etc/mysql/mariadb.conf.d/50-server.cnf
```

### Docker外のネットワークからログインできるか確認

#### できないもの

```
mysql -h 127.0.0.1 -P 3306 -u root -p
mysql -h 127.0.0.1 -P 3306 -u ユーザー名 -p

mysql -h localhost -P 3306 -u root -p
mysql -h localhost -P 3306 -u ユーザー名 -p
```

#### できるもの
##### Docker外部からの接続
ipアドレスはホストのipを設定する
PCにmysqlコマンドが使える状態なら、下記で確認できる
```
mysql -h 192.168.10.11 -P 3306 -u xiaobff -p
mysql -h 192.168.10.11 -P 3306 -u root -p

```

スマホから見たい場合は、コンテナで起動している`Adminer`を使用し、`192.168.10.11:8080`で、上記の情報を使用しDBのアクセスチェックも可能

##### Docker内からの接続
Dockerコンテナにアクセス
```
docker exec -it docker-mariadb-aspnet80-mysql-1 bash
```

コンテナ内で実施
```
mysql -u xiaobff -p 
mysql -u root -p

```
↓
```
# こんな感じ
root@acbde57c4e83:/# mysql -u xiaobff -p
root@acbde57c4e83:/# mysql -u root -p
```



