<?php
if(isset($_POST['nome']) && isset($_POST['apagar'])){
    if(file_exists("./".$_POST['nome'])){
        unlink("./".$_POST['nome']);
        header('location: index.php');
    }
}
?>
