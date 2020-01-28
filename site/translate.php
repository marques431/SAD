<?php
$lang = (!empty($_GET['lang'])) ? $_GET['lang'] : "";
switch ($lang){
    case "en":
        $t = [
            "menu" => [
                "services" => "Services",
                "team" => "Team",
                "contacts" => "Contacts",
                "login" => "Login",
                "app" => "Application"
            ],
            "welcome" => "Welcome to WeSAVE",
            "solutions" => "Renewable solutions",
            "services" => [
                "title" => "Services",
                "list" => "List of services",
                "solar-panels" => [
                    "title" => "Solar Panels",
                    "desc" => "We simulate the savings for the install of one or more solar panels, while recommending the best panel for your home!"
                ]
            ],
            "team" => [
                "title" => "Our Team",
                "pm" => "Project Manager",
                "sec" => "Sercretary",
                "an" => "Analist",
                "dev" => "Developer",
                "desc" => "A skilled and experienced team able to respond to the customers needs quickly and effectively, offering 24/7 support.",
            ],
            "app" =>[
                "download_txt" => "Download our app!",
                "download" => "Download"
            ],
            "contact" => [
                "title" => "Contact us!",
                "name" => "Insert your name",
                "email" => "Insert your email",
                "contact" => "Insert your contact",
                "message" => "Insert your message",
                "send" => "Send message",
                "success" => "Contact sent successfully",
                "error" => "There was an error"
            ]
        ];
    break;
    case "pt":
    default:
        $t = [
            "menu" => [
                "services" => "Serviços",
                "team" => "Equipa",
                "contacts" => "Contactos",
                "login" => "Login",
                "app" => "Aplicação"
            ],
            "welcome" => "Bem-vindo à WeSAVE",
            "solutions" => "Soluções Renováveis",
            "services" => [
                "title" => "Serviços",
                "list" => "Lista de serviços prestados",
                "solar-panels" => [
                    "title" => "Paineis Solares",
                    "desc" => "Fazemos uma simulação de poupança, para a instalação de um ou mais paineis solares, recomendando o melhor painel para a sua habitação!"
                ],
            ],
            "app" =>[
                "download_txt" => "Transfira a nossa aplicação!",
                "download" => "Transferir"
            ],
            "team" => [
                "title" => "A Nossa Equipa",
                "pm" => "Project Manager",
                "sec" => "Sercretário",
                "an" => "Analista",
                "dev" => "Programador",
                "desc" => "Uma equipa de trabalho qualificada e experiente, capaz de responder às necessidades do cliente com rapidez e eficácia, oferecendo suporte 24/7."
            ],
            "contact" => [
                "title" => "Entra em contacto connosco!",
                "name" => "Introduza o seu nome",
                "email" => "Introduza o seu email",
                "contact" => "Introduza o seu contacto",
                "message" => "Introduza a sua mensagem",
                "send" => "Enviar mensagem",
                "success" => "Contacto enviado com successo!",
                "error" => "Erro ao enviar o contacto"
            ]
        ];
    break;
}
?>
