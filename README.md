
## 目次

- [目次](#目次)
- [前提条件](#前提条件)
- [インストール](#インストール)
- [使い方 (Docker-Compose)](#使い方-docker-compose)
  - [起動](#起動)
  - [停止](#停止)
- [使い方 (CLI)](#使い方-cli)
  - [(初回起動時に実施)DBのマイグレーション](#初回起動時に実施dbのマイグレーション)
  - [起動](#起動-1)
- [APIエンドポイント一覧](#apiエンドポイント一覧)

## 前提条件

このプロジェクトを実行するために必要な前提条件を以下に示します。

- [.NET Core SDK](https://dotnet.microsoft.com/download) (.NET 7.0)
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/install/)

◼︎Dockerを使用しない場合は以下のセットアップが必要
- [.NET Core SDK](https://dotnet.microsoft.com/download) (.NET 7.0)

## インストール

プロジェクトのクローンを作成します。

```bash
git clone https://github.com/hirotaka42/docker-mariadb-asp.net7.0.git
cd docker-mariadb-asp.net7.0
```

## 使い方 (Docker-Compose)
### 起動
Docker Composeを使用してプロジェクトを起動します。
```
docker-compose up --build
```
APIエンドポイントにアクセスするには、ブラウザまたはAPIクライアント（例: Postman）を使用して以下のURLにアクセスします。

DockerではHTTPSではなく、HTTPでの接続になります

・http://localhost:5200/swagger/index.html  
・http://localhost:5200/エンドポイント


### 停止
Docker Composeを使用してプロジェクトを停止します。
```
docker-compose down
```

## 使い方 (CLI)
 .NET 7 SDK がインストールされている事
 https://dotnet.microsoft.com/ja-jp/download/dotnet


### (初回起動時に実施)DBのマイグレーション

マイグレーションツールのインストール
```
dotnet tool install --global dotnet-ef --version "7.*"
dotnet ef --version
```

マイグレーションの実施
```
# migrationsの新規作成はリポジトリに含まれているため、不要
# dotnet ef migrations add InitialCreate
# マイグレーションの実施
dotnet ef database update
```


### 起動
```
dotnet run
```
APIエンドポイントにアクセスするには、ブラウザまたはAPIクライアント（例: Postman）を使用して以下のURLにアクセスします。

CLIではHTTPSではなく、HTTPでの接続になります

・http://localhost:ランダムなポート番号/swagger/index.html  
・http://localhost:ランダムなポート番号/エンドポイント



## APIエンドポイント一覧
APIの主要なエンドポイントを以下に示します。

|リクエスト|エンドポイント|パラメータ|クエリ|レスポンス|
|---|---|---|---|---|

