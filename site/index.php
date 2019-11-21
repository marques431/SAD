<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>WeSave</title>

    <!-- Bootstrap core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom fonts for this template -->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css">
    <link href='https://fonts.googleapis.com/css?family=Kaushan+Script' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Droid+Serif:400,700,400italic,700italic' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700' rel='stylesheet' type='text/css'>

    <!-- Custom styles for this template -->
    <link href="css/agency.min.css" rel="stylesheet">
    <link href="css/custom.css" rel="stylesheet">
    <link rel="icon" href="./img/logos/wesave.png">

</head>

<body id="page-top">
    <?php include('translate.php') ?>
    <!-- Navigation -->
    <nav class="navbar navbar-expand-lg navbar-dark fixed-top" id="mainNav">
        <div class="container">
            <a class="navbar-brand js-scroll-trigger" href="#page-top">
                <img src="img/logos/wesave.png" style="width:50px; padding-bottom:5px">
                WeSave
            </a>
            <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                Menu
                <i class="fas fa-bars"></i>
            </button>
            <div class="collapse navbar-collapse" id="navbarResponsive">
                <ul class="navbar-nav text-uppercase ml-auto">
                    <li class="nav-item ma">
                        <?php
                        if($lang == "en"){
                            ?><a href="index.php"><img src="img/trans/pt-pt.png"></a><?php
                        }else{
                            ?><a href="index.php?lang=en"><img src="img/trans/en.png"></a><?php
                        }
                        ?>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" href="#services"><?php echo $t['menu']['services'] ?></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" href="#team"><?php echo $t['menu']['team'] ?></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" href="#contact"><?php echo $t['menu']['contacts'] ?></a>
                    </li>
                    <li class="nav-item">
                        <a href="login.php">
                            <button class="btn btn-primary btn-xs">Login</button>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <!-- Header -->
    <header class="masthead">
        <div class="container">
            <div class="intro-text">
                <div class="intro-lead-in" style="color: yellow !important"><?php echo $t['welcome'] ?></div>
                <div class="intro-heading text-uppercase"><?php echo $t['solutions'] ?></div>
            </div>
        </div>
    </header>

    <!-- Services -->
    <section class="page-section" id="services">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="section-heading text-uppercase"><?php echo $t['services']['title'] ?></h2>
                    <h3 class="section-subheading text-muted"><?php echo $t['services']['list'] ?>: </h3>
                </div>
            </div>
            <div class="row text-center">
                <div class="col-md-4 ma">
                    <span class="fa-stack fa-4x">
                        <i class="fas fa-circle fa-stack-2x text-primary"></i>
                        <i class="fas fa-shopping-cart fa-stack-1x fa-inverse"></i>
                    </span>
                    <h4 class="service-heading"><?php echo $t['services']['solar-panels']['title'] ?></h4>
                    <p class="text-muted"><?php echo $t['services']['solar-panels']['desc'] ?></p>
                </div>
            </div>
        </div>
    </section>

    <!-- Team -->
    <section class="bg-light page-section" id="team">
        <div class="container">
            <div class="row">
                <div class="col-lg-12" style="text-align: center">
                    <h2 class="section-heading text-uppercase"><?php echo $t['team']['title'] ?></h2>
                    <h3 class="section-subheading text-muted">.</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="img/team/joao.png" alt="">
                        <h4>João Varela</h4>
                        <p class="text-muted"><?php echo $t['team']['pm'] ?></p>

                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="img/team/joao2.jpg" alt="">
                        <h4>João Nogueira</h4>
                        <p class="text-muted"><?php echo $t['team']['sec'] ?></p>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="img/team/ivo.jpg" alt="">
                        <h4>Ivo Ferreira</h4>
                        <p class="text-muted"><?php echo $t['team']['an'] ?></p>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="img/team/1.png" alt="">
                        <h4>Patryck Tomaszewski</h4>
                        <p class="text-muted"><?php echo $t['team']['an'] ?></p>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="img/team/ruben.png" alt="">
                        <h4>Rúben Silva</h4>
                        <p class="text-muted"><?php echo $t['team']['dev'] ?></p>

                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="img/team/mario.jpg" alt="">
                        <h4>Mário Marques</h4>
                        <p class="text-muted"><?php echo $t['team']['dev'] ?></p>

                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="img/team/rodrigo.jpg" alt="">
                        <h4>Rodrigo Marques</h4>
                        <p class="text-muted"><?php echo $t['team']['dev'] ?></p>

                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-8 mx-auto text-center">
                    <p class="large text-muted"><?php echo $t['team']['desc'] ?></p>
                </div>
            </div>
        </div>
    </section>

    <!-- Contact -->
    <section class="page-section" id="contact">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="section-heading text-uppercase"><?php echo $t['contact']['title'] ?></h2>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12">
                    <?php
                    $erro = "";
                    if(isset($_POST['name']) && isset($_POST['email']) && isset($_POST['phone']) && isset($_POST['message'])){
                        $name = strip_tags(htmlspecialchars($_POST['name']));
                        $email_address = strip_tags(htmlspecialchars($_POST['email']));
                        $phone = strip_tags(htmlspecialchars($_POST['phone']));
                        $message = strip_tags(htmlspecialchars($_POST['message']));

                        include('./liga_bd.php');
                        $sql = "INSERT INTO  contacts (name, email, phone, message) VALUES ('$name','$email_address','$phone','$message')";
                        $res = $conn->query($sql);
                        if($res){
                            ?>
                            <div class="success">
                                <?php echo $t['contact']['success'] ?>
                            </div>
                            <?php
                        }else{
                            $error = $t['contact']['error'];
                        }
                        if(!empty($erro)){
                            echo '<div class="error">
                            '.$erro.'
                            </div>';
                        }
                        ?><script>
                        window.location.hash = '#contact';
                        </script>
                        <?php
                    }
                    ?>
                    <form id="formContact" name="formContact" target="_self" method="post">
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <input class="form-control" id="name" name="name" type="text" placeholder="<?php echo $t['contact']['name'] ?>" required="required" data-validation-required-message="<?php echo $t['contact']['name'] ?>">
                                    <p class="help-block text-danger"></p>
                                </div>
                                <div class="form-group">
                                    <input class="form-control" id="email" name="email" type="email" placeholder="<?php echo $t['contact']['email'] ?>" required="required" data-validation-required-message="<?php echo $t['contact']['email'] ?>">
                                    <p class="help-block text-danger"></p>
                                </div>
                                <div class="form-group">
                                    <input class="form-control" id="phone" name="phone" type="tel" placeholder="<?php echo $t['contact']['contact'] ?>" required="required" data-validation-required-message="<?php echo $t['contact']['contact'] ?>">
                                    <p class="help-block text-danger"></p>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <textarea class="form-control" id="message" name="message" placeholder="<?php echo $t['contact']['message'] ?>" required="required" data-validation-required-message="<?php echo $t['contact']['message'] ?>"></textarea>
                                    <p class="help-block text-danger"></p>
                                </div>
                            </div>
                            <div class="clearfix"></div>
                            <div class="col-lg-12 text-center">
                                <button class="btn btn-primary btn-xl text-uppercase" type="submit"><?php echo $t['contact']['send'] ?></button>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </section>


    <!-- Bootstrap core JavaScript -->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Plugin JavaScript -->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

    <!-- Contact form JavaScript -->
    <script src="js/jqBootstrapValidation.js"></script>
    <!-- <script src="js/contact_me.js"></script> -->

    <!-- Custom scripts for this template -->
    <script src="js/agency.min.js"></script>

</body>

</html>
