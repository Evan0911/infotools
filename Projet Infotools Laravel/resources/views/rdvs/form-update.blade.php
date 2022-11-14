<div class="row">
    <div class="col-xs-12 col-sm-12 col-md-12">
        <div class="form-group">
            <strong>Prénom:</strong>
            <input id="prenomCli" type="text" name="prenomCli" value="{{ $client->prenomCli }}" >
        </div>
    </div>
    <div class="col-xs-12 col-sm-12 col-md-12">
        <div class="form-group">
            <strong>Nom:</strong>
            <input id="nomCli" type="text" name="nomCli" value="{{ $client->nomCli }}">
        </div>
    </div>
    <div class="col-xs-12 col-sm-12 col-md-12">
        <div class="form-group">
            <strong>Adresse:</strong>
            <input id="adresseCli" type="text" name="adresseCli" value="{{ $client->adresseCli }}">
        </div>
    </div>
    <div class="col-xs-12 col-sm-12 col-md-12">
        <div class="form-group">
            <strong>Code postal:</strong>
            <input id="cpCli" type="text" name="cpCli" value="{{ $client->cpCli }}">
        </div>
    </div>
    <div class="col-xs-12 col-sm-12 col-md-12">
        <div class="form-group">
            <strong>Ville:</strong>
            <input id="villeCli" type="text" name="villeCli" value="{{ $client->villeCli }}">
        </div>
    </div>
    <div class="col-xs-12 col-sm-12 col-md-12">
        <div class="form-group">
            <strong>Téléphone:</strong>
            <input id="telCli" type="text" name="telCli" value="{{ $client->telCli }}">
        </div>
    </div>
    <div class="col-xs-12 col-sm-12 col-md-12">
        <div class="form-group">
            <strong>Mail:</strong>
            <input id="mailCli" type="mail" name="mailCli" value="{{ $client->mailCli }}">
        </div>
    </div>
    <div class="col-xs-12 col-sm-12 col-md-12 text-center">
            <button type="submit" class="btn btn-primary">Submit</button>
    </div>
</div>
