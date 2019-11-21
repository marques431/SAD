<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>Login</title>
		<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.1/css/all.css">
        <style>
        * {
          	box-sizing: border-box;
          	font-family: -apple-system, BlinkMacSystemFont, "segoe ui", roboto, oxygen, ubuntu, cantarell, "fira sans", "droid sans", "helvetica neue", Arial, sans-serif;
          	font-size: 16px;
          	-webkit-font-smoothing: antialiased;
          	-moz-osx-font-smoothing: grayscale;
        }
        body {
          	background-color: #435165;
        }
        .login {
          	width: 400px;
          	background-color: #ffffff;
          	box-shadow: 0 0 9px 0 rgba(0, 0, 0, 0.3);
          	margin: 100px auto;
        }
        .login h1 {
          	text-align: center;
          	color: #5b6574;
          	font-size: 24px;
          	padding: 20px 0 20px 0;
          	border-bottom: 1px solid #dee0e4;
        }
        .login form {
          	display: flex;
          	flex-wrap: wrap;
          	justify-content: center;
          	padding-top: 20px;
        }
        .login form label {
          	display: flex;
          	justify-content: center;
          	align-items: center;
          	width: 50px;
          	height: 50px;
          	background-color: #3274d6;
          	color: #ffffff;
        }
        .login form input[type="password"], .login form input[type="text"] {
          	width: 310px;
          	height: 50px;
          	border: 1px solid #dee0e4;
          	margin-bottom: 20px;
          	padding: 0 15px;
        }
        .login form input[type="submit"] {
          	width: 100%;
          	padding: 15px;
         	margin-top: 20px;
          	background-color: #3274d6;
          	border: 0;
          	cursor: pointer;
          	font-weight: bold;
          	color: #ffffff;
          	transition: background-color 0.2s;
        }
        .login form input[type="submit"]:hover {
        	background-color: #2868c7;
          	transition: background-color 0.2s;
        }

		/* custom */
		.alert{
			padding: 15px;
		    margin-bottom: 20px;
		    border: 1px solid transparent;
		    border-radius: 4px;
		}
		.alert-danger{
			color: #a94442;
		    background-color: #f2dede;
		    border-color: #ebccd1;
		}

        </style>
	</head>
	<body>
        <?php
			session_start();
			if(isset($_SESSION['id'])){
				header('location: diretorio');
			}
			if(isset($_POST['submit'])){
				include './liga_bd.php';
				$password = md5($_POST['password']);
				$sql = "SELECT id, email FROM users WHERE email = '".$_POST['email']."' AND password = '".$password."'";
				$res = $conn->query($sql);
				$count = mysqli_num_rows($res);
				if($count == 1) {
					$row = $res->fetch_assoc();
					$_SESSION['id'] = $row['id'];
					//echo "bem-vindo";
					header('location: diretorio');
				}else {
					$erro = "Dados incorretos!";
				}
			}
		?>
		<?php if(!empty($erro)){ ?>
			<div class="alert alert-danger">
				<?php echo $erro; ?>
			</div>
		<?php } ?>
		<div class="login">
			<h1>Login</h1>
			<form action="#" method="post">
				<label for="username">
					<i class="fas fa-user"></i>
				</label>
				<input type="text" name="email" placeholder="Email" id="email" required>
				<label for="password">
					<i class="fas fa-lock"></i>
				</label>
				<input type="password" name="password" placeholder="Password" id="password" required>
				<input type="submit" name="submit">
			</form>
		</div>
	</body>
</html>
